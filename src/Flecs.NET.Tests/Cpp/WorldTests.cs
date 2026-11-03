using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Flecs.NET.Core;
using Xunit;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Tests.Cpp;

// The log tests replace the global os api log callback, so this collection must not run in parallel.
[CollectionDefinition("World", DisableParallelization = true)]
public class WorldCollection;

[Collection("World")]
[SuppressMessage("ReSharper", "UnusedParameter.Local")]
public unsafe class WorldTests
{
    [Fact]
    public void Shrink()
    {
        using World world = World.Create();

        Entity e = world.Entity().Set(new Position { X = 10, Y = 20 });

        world.Shrink();

        Assert.True(e.IsAlive());
        Assert.Equal(10, e.Get<Position>().X);
    }

    [Fact]
    public void ExclusiveAccessSelfMutate()
    {
        using World world = World.Create();

        world.ExclusiveAccessBegin();

        Entity e = world.Entity();

        e.Add<Position>();
        Assert.True(e.Has<Position>());

        world.ExclusiveAccessEnd();
    }

    [Fact]
    public void IdIfRegistered()
    {
        using World world = World.Create();

        Assert.Equal(0ul, world.IdIfRegistered<Position>());
        Assert.Equal(0ul, world.IdIfRegistered<Position>());

        Entity c = world.Component<Position>();

        Assert.Equal(c.Id.Value, world.IdIfRegistered<Position>());
    }

    [Fact]
    public void GetTypeInfoT()
    {
        using World world = World.Create();

        Entity c = world.Component<Position>();

        TypeInfo ti = world.TypeInfo(c);
        Assert.True(ti.Handle != null);
        Assert.Equal(sizeof(Position), ti.Size);
        Assert.Equal(4, ti.Alignment);
        Assert.Equal(c.Id.Value, ti.Component);
    }

    [Fact]
    public void GetTypeInfoT2()
    {
        using World world = World.Create();

        TypeInfo ti = world.TypeInfo<Position>();
        Assert.True(ti.Handle != null);
        Assert.Equal(sizeof(Position), ti.Size);
        Assert.Equal(4, ti.Alignment);
        Assert.Equal((ulong)world.Component<Position>(), ti.Component);
    }

    [Fact]
    public void GetTypeInfoRt()
    {
        using World world = World.Create();

        Entity c = world.Component<Position>();
        Entity tgt = world.Entity();

        TypeInfo ti = world.TypeInfo(c, tgt);
        Assert.True(ti.Handle != null);
        Assert.Equal(sizeof(Position), ti.Size);
        Assert.Equal(4, ti.Alignment);
        Assert.Equal(c.Id.Value, ti.Component);
    }

    [Fact]
    public void GetTypeInfoRT()
    {
        using World world = World.Create();

        Entity c = world.Component<Position>();
        Entity tgt = world.Entity();

        TypeInfo ti = world.TypeInfo<Position>(tgt);
        Assert.True(ti.Handle != null);
        Assert.Equal(sizeof(Position), ti.Size);
        Assert.Equal(4, ti.Alignment);
        Assert.Equal(c.Id.Value, ti.Component);
    }

    [Fact]
    public void GetTypeInfoRT2()
    {
        using World world = World.Create();

        Entity c = world.Component<Position>();

        TypeInfo ti = world.TypeInfo<Position, Tgt>();
        Assert.True(ti.Handle != null);
        Assert.Equal(sizeof(Position), ti.Size);
        Assert.Equal(4, ti.Alignment);
        Assert.Equal(c.Id.Value, ti.Component);
    }

    [Fact]
    public void GetTypeInfoTTag()
    {
        using World world = World.Create();

        Entity c = world.Component<Tag>();

        TypeInfo ti = world.TypeInfo(c);
        Assert.True(ti.Handle == null);
    }

    [Fact]
    public void GetTypeInfoT2Tag()
    {
        using World world = World.Create();

        TypeInfo ti = world.TypeInfo<Tag>();
        Assert.True(ti.Handle == null);
    }

    [Fact]
    public void GetTypeInfoRtTag()
    {
        using World world = World.Create();

        Entity c = world.Component<Tag>();
        Entity tgt = world.Entity();

        TypeInfo ti = world.TypeInfo(c, tgt);
        Assert.True(ti.Handle == null);
    }

    [Fact]
    public void GetTypeInfoRTTag()
    {
        using World world = World.Create();

        Entity tgt = world.Entity();

        TypeInfo ti = world.TypeInfo<Tag>(tgt);
        Assert.True(ti.Handle == null);
    }

    [Fact]
    public void GetTypeInfoRT2Tag()
    {
        using World world = World.Create();

        TypeInfo ti = world.TypeInfo<Tag, Tgt>();
        Assert.True(ti.Handle == null);
    }

    [Fact]
    public void GetVersion()
    {
        using World world = World.Create();

        Entity e = world.Entity();

        Assert.Equal(0u, world.GetVersion(e));

        e.Destruct();
        Entity recycled = world.Entity();

        Assert.Equal(1u, world.GetVersion(recycled));
    }

    [Fact]
    public void FiniWScopedComponentAddedToBuiltin()
    {
        using World world = World.Create();

        world.Component<Outer.ScopedComponent>("::outer::ScopedComponent");
        world.Entity<EcsIdentifier>().Set(new Outer.ScopedComponent { X = 10, Y = 20 });

        Assert.True(world.Entity<EcsIdentifier>().Has<Outer.ScopedComponent>());
        Assert.True(world.Lookup("::outer::ScopedComponent") != 0);
    }

    [Fact]
    public void FiniWScopedTagAddedToBuiltin()
    {
        using World world = World.Create();

        world.Component<Outer.ScopedTag>("::outer::ScopedTag");
        world.Entity<EcsIdentifier>().Add<Outer.ScopedTag>();

        Assert.True(world.Entity<EcsIdentifier>().Has<Outer.ScopedTag>());
        Assert.True(world.Lookup("::outer::ScopedTag") != 0);
    }

    [Fact]
    public void LogWarnCallerFileLine()
    {
        using LogCaptureScope _ = InstallLogCapture();
        int line = Line(); Ecs.Log.Warn("warn 10");
        Assert.Equal(-2, LogCaptureLevel);
        Assert.Equal("warn 10", LogCaptureMessage);
        CheckLogLocation(line);
    }

    [Fact]
    public void LogErrCallerFileLine()
    {
        using LogCaptureScope _ = InstallLogCapture();
        int line = Line(); Ecs.Log.Err("err 20");
        Assert.Equal(-3, LogCaptureLevel);
        Assert.Equal("err 20", LogCaptureMessage);
        CheckLogLocation(line);
    }

    [Fact]
    public void LogTraceCallerFileLine()
    {
        using LogCaptureScope _ = InstallLogCapture();
        int line = Line(); Ecs.Log.Trace("trace 30");
        Assert.Equal(0, LogCaptureLevel);
        Assert.Equal("trace 30", LogCaptureMessage);
        CheckLogLocation(line);
    }

    [Fact]
    public void LogDbgCallerFileLine()
    {
        using LogCaptureScope _ = InstallLogCapture();
        int line = Line(); Ecs.Log.Dbg("dbg 40");
        Assert.Equal(1, LogCaptureLevel);
        Assert.Equal("dbg 40", LogCaptureMessage);
        CheckLogLocation(line);
    }

    [Fact]
    public void LogPushCallerFileLine()
    {
        using LogCaptureScope _ = InstallLogCapture();
        int line = Line(); Ecs.Log.Push("push 50");
        Assert.Equal(0, LogCaptureLevel);
        Assert.Equal("push 50", LogCaptureMessage);
        CheckLogLocation(line);
        Ecs.Log.Pop();
    }

    [Fact]
    public void LogOverridePersistsAcrossWorldCreation()
    {
        // SetLog runs before World.Create(), so the override has to survive the first ecs_init().
        using LogCaptureScope _ = InstallLogCapture();

        using World world1 = World.Create();
        Ecs.Log.Err("after first world");
        Assert.Equal("after first world", LogCaptureMessage);

        using World world2 = World.Create();
        Ecs.Log.Err("after second world");
        Assert.Equal("after second world", LogCaptureMessage);
    }

    private static int Line([CallerLineNumber] int line = 0)
    {
        return line;
    }

    private static LogCaptureScope InstallLogCapture()
    {
        // Install once; it only records into thread static fields and cannot be uninstalled through the public api.
        if (!LogCaptureInstalled)
        {
            LogCaptureInstalled = true;
            Ecs.Os.SetLog((int level, string file, int line, string message) =>
            {
                LogCaptureLevel = level;
                LogCaptureFile = file;
                LogCaptureLine = line;
                LogCaptureMessage = message;
            });
        }

        LogCaptureScope scope = new(Ecs.Log.GetLevel(), ecs_log_enable_colors(false));
        Ecs.Log.SetLevel(4);

        LogCaptureFile = "";
        LogCaptureLine = 0;
        LogCaptureLevel = 100;
        LogCaptureMessage = "";

        return scope;
    }

    private readonly struct LogCaptureScope : IDisposable
    {
        private readonly int _level;
        private readonly bool _colors;

        public LogCaptureScope(int level, bool colors)
        {
            _level = level;
            _colors = colors;
        }

        public void Dispose()
        {
            Ecs.Log.SetLevel(_level);
            ecs_log_enable_colors(_colors);
        }
    }

    private static void CheckLogLocation(int expectedLine)
    {
        Assert.True(LogCaptureFile != "");
        Assert.True(LogCaptureLine > 0);
        Assert.EndsWith("WorldTests.cs", LogCaptureFile);
        Assert.Equal(expectedLine, LogCaptureLine);
    }

    private static bool LogCaptureInstalled;

    [ThreadStatic] private static int LogCaptureLevel;
    [ThreadStatic] private static string LogCaptureFile = "";
    [ThreadStatic] private static int LogCaptureLine;
    [ThreadStatic] private static string LogCaptureMessage = "";
}
