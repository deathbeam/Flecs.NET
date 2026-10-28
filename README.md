# Flecs.NET
![](https://raw.githubusercontent.com/SanderMertens/flecs/master/docs/img/logo.png)

<div align="center">

[![MIT](https://img.shields.io/badge/license-MIT-blue.svg?style=for-the-badge)](https://github.com/SanderMertens/flecs/blob/master/LICENSE)
[![NuGet](https://img.shields.io/badge/packages-nuget.org-blue?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages?q=Deathbeam.Flecs.NET)

[Docs](https://www.flecs.dev/flecs/) · [Examples](https://github.com/deathbeam/Flecs.NET/tree/main/src/Flecs.NET.Examples) · [Discord](https://discord.gg/BEzP5Rgrrp)

</div>

**Flecs.NET** is a high-level wrapper for [flecs](https://github.com/SanderMertens/flecs). Low-level bindings to the C api are included and generated with [Bindgen.NET](https://github.com/deathbeam/Bindgen.NET). Native libraries are cross-compiled with [Vezel-Dev's Zig Toolsets](https://github.com/vezel-dev/zig-toolsets).

## Show me the code!
```csharp
// Copy, paste, and run in a .NET project!

using Flecs.NET.Core;

using World world = World.Create();

Entity entity = world.Entity()
    .Set(new Position(10, 20))
    .Set(new Velocity(1, 2));

world.Each(static (ref Position p, ref Velocity v) =>
{
    p.X += v.X;
    p.Y += v.Y;
});

public record struct Position(float X, float Y);
public record struct Velocity(float X, float Y);
```

## Overview
**Flecs.NET - High-level C# port of the C++ wrapper**
- Modern .NET 9
- Near feature parity with the C++ API
- Struct-based API with minimal GC interaction
- Supports both unmanaged and managed types as components
- Implicitly registers components on-the-fly

**Flecs.NET.Bindings - Low-level bindings of the C API**
- Build your own wrapper to suite your personal needs
- Auto-generated bindings for the entire flecs API
- Fully blittable interface with no runtime marshalling

**Flecs.NET.Native - Precompiled native libraries**
- Provides both shared and static libraries for Windows, MacOS, Linux, iOS, and WASM
- Packaged with Zig for dependency free cross-compilation everywhere

## Installation
You can use the latest builds from NuGet:

```xml
<ItemGroup>
    <PackageReference Include="Deathbeam.Flecs.NET.Debug" Version="*-build.*" Condition="'$(Configuration)' == 'Debug'" />
    <PackageReference Include="Deathbeam.Flecs.NET.Release" Version="*-build.*" Condition="'$(Configuration)' == 'Release'" />
</ItemGroup>
```

Or from GitHub Packages (replace `YOUR_GITHUB_USERNAME` and `YOUR_GITHUB_TOKEN` with your GitHub username and [classic personal access token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens#creating-a-personal-access-token-classic) with `read:packages` scope):

```sh
dotnet nuget add source --name "deathbeam" --username "YOUR_GITHUB_USERNAME" --password "YOUR_GITHUB_TOKEN" --store-password-in-clear-text "https://nuget.pkg.github.com/deathbeam/index.json"
```

## Running examples
To run any of the example programs, use `dotnet run` and set the "Example" property to the example's path relative to the `Flecs.NET.Examples` project. Each level of the path must be separated by an underscore.

**Example**:
```bash
dotnet run --project src/Flecs.NET.Examples --property:Example=Entities_Basics
```

## Building from source
### Clone the repo
Clone the repo and it's submodules.
```bash
git clone --recursive https://github.com/deathbeam/Flecs.NET.git
cd Flecs.NET
```

### Restore dependencies
Run the following command on the solution to restore all project dependencies.
```bash
dotnet restore
```

### Build Flecs.NET
Compile the wrapper and native libraries. The [zig](https://ziglang.org/learn/overview/#cross-compiling-is-a-first-class-use-case) compiler will automatically be downloaded and cached in your local nuget package folder. Native libraries will be cross-compiled for linux, macos, and windows.
```bash
dotnet build
```

### Reference the project
Reference the project and import the native libraries. You should now be able to use **Flecs.NET** from your project.

```xml
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net9.0</TargetFramework>
    </PropertyGroup>

    <ItemGroup>
        <ProjectReference Include="PATH/Flecs.NET/src/Flecs.NET/Flecs.NET.csproj" />
    </ItemGroup>
</Project>
```

### Running the bindings generator
Low-level bindings to the flecs C API are pre-generated and included in the [Flecs.NET.Bindings](https://github.com/deathbeam/Flecs.NET/tree/main/src/Flecs.NET.Bindings) project by default. If needed, you can run the following command to regenerate the bindings file.
```bash
dotnet run --project src/Flecs.NET.Bindgen

```
### Running the code generator
**Flecs.NET** relies on code generation to avoid manual code duplication. If any changes are made to the [Flecs.NET.Codegen](https://github.com/deathbeam/Flecs.NET/tree/main/src/Flecs.NET.Codegen) project, you can run the following command to rerun the code generators. The generated files will be output to this [folder](https://github.com/deathbeam/Flecs.NET/tree/main/src/Flecs.NET/Generated).
```bash
dotnet run --project src/Flecs.NET.Codegen
```

## Contributing
Feel free to open an issue or pull request. All contributions are welcome!

**Ways to contribute:**
- Bug Fixes/Reports
- Feature Requests
- Documentation
- Examples/Snippets
- Demos
- Typo Corrections
