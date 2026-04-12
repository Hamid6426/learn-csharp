# DOTNET SDK SETUP GUIDE

---

## DOWNLOAD

- Go to [dotnet.microsoft.com/download](https://dotnet.microsoft.com/en-us/download)
- Find compatible dotnet version for the hardware.
- Download a .NET SDK of later versions.

---

## INSTALLATION

1. Run the installer and follow the on-screen prompts
2. Complete the installation process
3. Verify the installation by opening PowerShell, typing `dotnet` and hit enter.
4. It will show available commands related to dotnet as a response instead of an error message.

---

## CREATE A PROJECT

1. Launch terminal and go to a folder.
2. Create a new console application: `dotnet new console -n DotnetApp`.
3. By the way, Dotnet prefer PascalCase for project names. For example, `DotnetApp`.
4. Write the simplest code in `Program.cs` and run the project using `dotnet run` command.
5. Build the project using `dotnet build` command to see the generated files and folders in the project directory.

---

## SIMPLEST CODE SNIPPET

```csharp
Console.WriteLine("Hello, World!");
```

---

```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

---

## DOTNET COMMANDS LIST

| Command          | Description                                                                      |
| ---------------- | -------------------------------------------------------------------------------- |
| `dotnet new`     | Creates a new .NET project based on a specified template                         |
| `dotnet build`   | Compiles the project and generates the output files                              |
| `dotnet run`     | Builds and runs the project in one step                                          |
| `dotnet clean`   | Removes all build artifacts and intermediate files from the project directory    |
| `dotnet publish` | Prepares the application for deployment by compiling and copying necessary files |
| `dotnet test`    | Runs unit tests in the project                                                   |

---

## FOLDER STRUCTURE

```
DotnetApp
├── DotnetApp.csproj
├── Program.cs
├── obj
│   ├── DotnetApp.csproj.nuget.dgspec.json
│   ├── DotnetApp.csproj.nuget.g.props
│   ├── DotnetApp.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
└── bin
    └── Debug
        └── net10.0
            ├── DotnetApp.deps.json
            ├── DotnetApp.dll
            ├── DotnetApp.exe
            ├── DotnetApp.pdb
            └── DotnetApp.runtimeconfig.json
```

---

## File Descriptions

| File/Directory                 | Description                                                                    |
| ------------------------------ | ------------------------------------------------------------------------------ |
| `.csproj`                      | XML project file containing build configuration, dependencies, and metadata    |
| `Program.cs`                   | Application entry point with the Main method                                   |
| `obj/`                         | Build artifacts directory containing NuGet metadata and dependency information |
| `bin/Debug/net10.0/`           | Compiled output directory with executable and runtime files                    |
| `DotnetApp.dll`                | Compiled assembly containing application code                                  |
| `DotnetApp.exe`                | Windows executable file                                                        |
| `DotnetApp.pdb`                | Debug symbols for debugging support                                            |
| `DotnetApp.runtimeconfig.json` | Runtime configuration specifying .NET version and settings                     |
| `DotnetApp.deps.json`          | Lock file with exact NuGet package versions and dependencies                   |
