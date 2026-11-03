using Flecs.NET.Core;
using Xunit;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Tests.Cpp;

public unsafe class ScriptTests
{
    // C++ maps int64_t/double to the builtin flecs.meta types, so use those ids explicitly to match its behavior.
    // Flecs.NET registers .NET primitives as separate components (e.g. Flecs.NET.Core.Ecs.Meta.Int64).
    private static ulong I64 => FLECS_IDecs_i64_tID_;
    private static ulong F64 => FLECS_IDecs_f64_tID_;

    private static void ScriptSum(ScriptFunction ctx, ScriptArgs args, ScriptValue result)
    {
        Assert.True(args.Count == 1 || args.Count == 2);
        long a = args[0].Get<long>();
        long b = args[1].Get<long>();
        long offset = ctx.Ctx != null ? *(long*)ctx.Ctx : 0;
        result.Get<long>() = a + b + offset;
    }

    private static void ScriptLerpFloat(ScriptFunction ctx, ScriptArgs args, ScriptValue result, int count)
    {
        Assert.Equal(3, args.Count);
        float* a = args[0].GetPtr<float>();
        float* b = args[1].GetPtr<float>();
        double t = args[2].Get<double>();
        float* r = result.GetPtr<float>();

        for (int i = 0; i < count; i++)
            r[i] = (float)(a[i] + t * (b[i] - a[i]));
    }

    private static void ScriptLerpDouble(ScriptFunction ctx, ScriptArgs args, ScriptValue result, int count)
    {
        Assert.Equal(3, args.Count);
        double* a = args[0].GetPtr<double>();
        double* b = args[1].GetPtr<double>();
        double t = args[2].Get<double>();
        double* r = result.GetPtr<double>();

        for (int i = 0; i < count; i++)
            r[i] = a[i] + t * (b[i] - a[i]);
    }

    [Fact]
    private void Function()
    {
        using World world = World.Create();

        Entity f = world.Function("sum")
            .ReturnType(I64)
            .Param("a", I64)
            .Param("b", I64)
            .Callback(ScriptSum)
            .Build();

        Assert.True(f != 0);
        Assert.Equal(0, world.ScriptRun(null!, "export const result = sum(10, 20)"));
        Assert.Equal(30, world.GetConstVar<long>("result"));
    }

    [Fact]
    private void FunctionScopeAndCtx()
    {
        using World world = World.Create();

        Entity parent = world.Entity("math");
        long offset = 5;

        using (world.Scope(parent))
        {
            Entity f = world.Function("sum")
                .ReturnType(I64)
                .Param("a", I64)
                .Param("b", I64)
                .Callback(ScriptSum)
                .Ctx(&offset)
                .Build();

            Assert.True(f.Parent() == parent);
        }

        Entity other = world.Entity("other");
        Entity f2 = world.Function("sum")
            .Parent(other)
            .ReturnType(I64)
            .Param("a", I64)
            .Param("b", I64)
            .Callback(ScriptSum)
            .Build();

        Assert.True(f2.Parent() == other);
        Assert.Equal(0, world.ScriptRun(null!, "export const result = math.sum(10, 20) + other.sum(1, 2)"));
        Assert.Equal(38, world.GetConstVar<long>("result"));
    }

    [Fact]
    private void Method()
    {
        using World world = World.Create();

        Entity m = world.Method(I64, "add")
            .ReturnType(I64)
            .Param("a", I64)
            .Callback(ScriptSum)
            .Build();

        Assert.True(m.Parent() == I64);
        Assert.Equal(0, world.ScriptRun(null!, "const v: i64 = 10\nexport const result = v.add(20)"));
        Assert.Equal(30, world.GetConstVar<long>("result"));
    }

    [Fact]
    private void VectorFunction()
    {
        using World world = World.Create();

        Entity f = world.Function("lerp")
            .ReturnType(EcsScriptVectorType)
            .Param("a", EcsScriptVectorType)
            .Param("b", EcsScriptVectorType)
            .Param("t", F64)
            .VectorCallback(EcsF32, ScriptLerpFloat)
            .VectorCallback(EcsF64, ScriptLerpDouble)
            .Build();

        Assert.True(f != 0);
        Assert.Equal(0, world.ScriptRun(null!, """
            struct V32(x: f32, y: f32)
            struct V64(x: f64, y: f64)
            const a: V32 = {10, 20}
            const b: V32 = {30, 40}
            const c: V64 = {20, 30}
            const d: V64 = {40, 50}
            export const r32: V32 = lerp(a, b, 0.5)
            export const r64: V64 = lerp(c, d, 0.25)
            """));

        ecs_value_t r32 = ecs_const_var_get(world, world.Lookup("r32"));
        ecs_value_t r64 = ecs_const_var_get(world, world.Lookup("r64"));

        Assert.True(r32.ptr != null);
        Assert.True(r64.ptr != null);
        Assert.Equal(20, ((float*)r32.ptr)[0]);
        Assert.Equal(30, ((float*)r32.ptr)[1]);
        Assert.Equal(25, ((double*)r64.ptr)[0]);
        Assert.Equal(35, ((double*)r64.ptr)[1]);
    }

    [Fact]
    private void ConstVar()
    {
        using World world = World.Create();

        double value = 3.1415926;
        Entity v = world.ConstVar("pi", F64, &value);
        Assert.True(v != 0);

        value = 0;
        Assert.Equal(3.1415926, world.GetConstVar<double>("pi"));
        Assert.Equal(0, world.ScriptRun(null!, "export const result = pi * 2"));
        Assert.Equal(6.2831852, world.GetConstVar<double>("result"));
    }

    [Fact]
    private void VarsScope()
    {
        using World world = World.Create();

        Entity parent = world.Entity("config");

        using (world.Scope(parent))
        {
            Assert.True(world.ConstVar("constant", 10).Parent() == parent);
            Assert.True(world.MutVar("mutable", 20.0f).Parent() == parent);
        }

        Assert.True(world.ConstVar("constant2", 30, parent).Parent() == parent);
        Assert.True(world.MutVar("mutable2", 40.0f, parent).Parent() == parent);

        Assert.Equal(10, world.GetConstVar<int>("config.constant"));
        Assert.Equal(30, world.GetConstVar<int>("config.constant2"));
        Assert.Equal(20, world.GetMutVar<float>("config.mutable"));
        Assert.Equal(0, world.SetMutVar(".config.mutable", 25.0));
        Assert.Equal(0, world.SetMutVar("config.mutable2", 45.0f));
        Assert.Equal(25, world.GetMutVar<float>("config.mutable"));
        Assert.Equal(45, world.GetMutVar<float>("config.mutable2"));
    }

    [Fact]
    private void MutVarReactive()
    {
        using World world = World.Create();

        Entity v = world.MutVar("difficulty", 1.0f);
        Assert.True(v != 0);

        Entity s = world.Script()
            .Code("struct Level(value: f32)\ne { Level: {difficulty} }")
            .Run();

        Assert.True(((EcsScript*)s.GetPtr(Ecs.Script))->error == null);

        Entity e = world.Lookup("e");
        Entity level = world.Lookup("Level");

        Assert.Equal(1, *(float*)e.GetPtr(level));
        Assert.Equal(0, world.SetMutVar("difficulty", 2.0f));
        Assert.Equal(2, *(float*)e.GetPtr(level));
        Assert.Equal(2, world.GetMutVar<float>("difficulty"));
    }

    [Fact]
    private void SetMutVarInvalid()
    {
        using World world = World.Create();

        int prevLogLevel = Ecs.Log.GetLevel();
        Ecs.Log.SetLevel(-4);
        Assert.Equal(-1, world.SetMutVar("missing", 1));

        world.Entity("ordinary");
        Assert.Equal(-1, world.SetMutVar("ordinary", 1));

        world.ConstVar("constant", 1);
        Assert.Equal(-1, world.SetMutVar("constant", 2));
        Assert.Equal(1, world.GetConstVar<int>("constant"));
        Ecs.Log.SetLevel(prevLogLevel);
    }

    [Fact]
    private void ParseEval()
    {
        using World world = World.Create();

        using ParsedScript script = world.ScriptParse("test", "e {}");
        Assert.True(script.IsValid);
        Assert.True(world.Lookup("e") == 0);

        Assert.Equal(0, script.Eval());

        Entity e = world.Lookup("e");
        Assert.True(e != 0);

        e.Destruct();
        Assert.Equal(0, script.Eval());
        Assert.True(world.Lookup("e") != 0);
    }

    [Fact]
    private void ParseError()
    {
        using World world = World.Create();

        ecs_script_eval_desc_t desc = default;
        ecs_script_eval_result_t result = default;
        ParsedScript script = world.ScriptParse("test", "e {", ref desc, ref result);

        Assert.False(script.IsValid);
        Assert.True(result.error != null);
        ecs_os_api.free_(result.error);
        Assert.Equal(-1, script.Eval());
    }

    [Fact]
    private void EvalError()
    {
        using World world = World.Create();

        using ParsedScript script = world.ScriptParse("test", "e { Missing }");
        Assert.True(script.IsValid);

        ecs_script_eval_desc_t desc = default;
        ecs_script_eval_result_t result = default;
        Assert.Equal(-1, script.Eval(ref desc, ref result));
        Assert.True(result.error != null);
        ecs_os_api.free_(result.error);
    }

    [Fact]
    private void Update()
    {
        using World world = World.Create();

        Entity s = world.Script().Code("old {}").Run();
        Assert.True(((EcsScript*)s.GetPtr(Ecs.Script))->error == null);
        Assert.True(world.Lookup("old") != 0);

        Assert.Equal(0, world.ScriptUpdate(s, "updated {}"));
        Assert.True(world.Lookup("old") == 0);
        Assert.True(world.Lookup("updated") != 0);
        Assert.True(((EcsScript*)s.GetPtr(Ecs.Script))->error == null);

        int prevLogLevel = Ecs.Log.GetLevel();
        Ecs.Log.SetLevel(-4);
        Assert.Equal(-1, world.ScriptUpdate(s, "updated { Missing }"));
        Assert.True(((EcsScript*)s.GetPtr(Ecs.Script))->error != null);
        Assert.Equal(0, world.ScriptUpdate(s, "recovered {}"));
        Assert.True(((EcsScript*)s.GetPtr(Ecs.Script))->error == null);
        Assert.True(world.Lookup("recovered") != 0);
        Ecs.Log.SetLevel(prevLogLevel);
    }
}
