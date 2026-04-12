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

---

## DOTNET COMMANDS LIST

### COMMON COMMANDS

| Command          | Description                                                                      |
| ---------------- | -------------------------------------------------------------------------------- |
| `dotnet new`     | Creates a new .NET project based on a specified template                         |
| `dotnet build`   | Compiles the project and generates the output files                              |
| `dotnet run`     | Builds and runs the project in one step                                          |
| `dotnet clean`   | Removes all build artifacts and intermediate files from the project directory    |
| `dotnet publish` | Prepares the application for deployment by compiling and copying necessary files |
| `dotnet test`    | Runs unit tests in the project                                                   |

### OTHER USEFUL COMMANDS

| Command                        | Description                                                 |
| ------------------------------ | ----------------------------------------------------------- |
| `dotnet add package`           | Adds a NuGet package reference to the project               |
| `dotnet remove package`        | Removes a NuGet package reference from the project          |
| `dotnet list package`          | Lists all NuGet packages referenced in the project          |
| `dotnet restore`               | Restores NuGet dependencies listed in the project file      |
| `dotnet add reference`         | Adds a project-to-project reference                         |
| `dotnet remove reference`      | Removes a project-to-project reference                      |
| `dotnet list reference`        | Lists all project references                                |
| `dotnet sln`                   | Manages solution files (add/remove/list projects)           |
| `dotnet ef migrations add`     | Creates a new EF Core migration                             |
| `dotnet ef migrations remove`  | Removes the last EF Core migration                          |
| `dotnet ef database update`    | Applies pending EF Core migrations to the database          |
| `dotnet ef database drop`      | Drops the database                                          |
| `dotnet ef dbcontext scaffold` | Reverse-engineers a DB schema into EF Core models           |
| `dotnet watch run`             | Runs the app with hot reload on file changes                |
| `dotnet watch test`            | Runs tests and re-runs on file changes                      |
| `dotnet format`                | Applies code style and formatting rules                     |
| `dotnet tool install`          | Installs a .NET CLI global or local tool                    |
| `dotnet tool update`           | Updates an installed .NET CLI tool                          |
| `dotnet tool list`             | Lists all installed .NET CLI tools                          |
| `dotnet tool uninstall`        | Removes an installed .NET CLI tool                          |
| `dotnet nuget push`            | Pushes a NuGet package to a feed                            |
| `dotnet nuget add source`      | Adds a NuGet package source                                 |
| `dotnet pack`                  | Creates a NuGet package from the project                    |
| `dotnet user-secrets init`     | Initializes user secrets storage for the project            |
| `dotnet user-secrets set`      | Sets a user secret key-value pair                           |
| `dotnet user-secrets list`     | Lists all user secrets for the project                      |
| `dotnet dev-certs https`       | Manages the local HTTPS development certificate             |
| `dotnet workload install`      | Installs a .NET workload (e.g., maui, wasm-tools)           |
| `dotnet workload list`         | Lists installed workloads                                   |
| `dotnet --info`                | Displays installed SDK/runtime info and environment details |
| `dotnet --list-sdks`           | Lists all installed .NET SDKs                               |
| `dotnet --list-runtimes`       | Lists all installed .NET runtimes                           |

### NEW TEMPLATES

| Command                              | Description                                |
| ------------------------------------ | ------------------------------------------ |
| `dotnet new console -n AppName`      | Creates a new Console application          |
| `dotnet new classlib -n AppName`     | Creates a Class Library                    |
| `dotnet new webapi -n AppName`       | Creates a Web API project                  |
| `dotnet new mvc -n AppName`          | Creates an ASP.NET Core MVC app            |
| `dotnet new blazorserver -n AppName` | Creates a Blazor Server app                |
| `dotnet new blazorwasm -n AppName`   | Creates a Blazor WebAssembly app           |
| `dotnet new worker -n AppName`       | Creates a Worker Service (background jobs) |
| `dotnet new grpc -n AppName`         | Creates a gRPC service                     |
| `dotnet new xunit -n AppName`        | Creates an xUnit test project              |
| `dotnet new nunit -n AppName`        | Creates an NUnit test project              |
| `dotnet new mstest -n AppName`       | Creates an MSTest project                  |
| `dotnet new sln -n AppName`          | Creates a Solution file                    |
| `dotnet new gitignore`               | Adds a .gitignore for .NET projects        |
| `dotnet new editorconfig`            | Adds a .editorconfig file                  |
| `dotnet new globaljson`              | Creates a global.json to pin SDK version   |

### FLAGS

| Flag                 | Description                                       |
| -------------------- | ------------------------------------------------- |
| `-n` / `--name`      | Sets the project/solution name                    |
| `-o` / `--output`    | Sets the output directory                         |
| `-f` / `--framework` | Targets a specific framework e.g. net8.0          |
| `--no-restore`       | Skips automatic dotnet restore after creation     |
| `--use-minimal-apis` | Scaffolds with minimal API style (webapi)         |
| `--dry-run`          | Shows what would be created without writing files |

## Visual Studio Code

### DOWNLOAD

- Visit [code.visualstudio.com/Download](https://code.visualstudio.com/Download) and download a compatible VSCode.

### INSTALLATION

1. Run the VSCode installer and follow the on-screen prompts
2. Complete the installation process
3. (Optional) Install the C# extension from the Extensions marketplace for enhanced C# support
4. Verify by clicking the Windows key and start typing `Visual Studio Code`, it will show up eventually. Click the application to launch it

### DOTNET EXTENSIONS

Install the `C# Dev Kit`, and `.NET Install Tool` extension from the VS Code extensions marketplace for csharp/dotnet development.

---

## Visual Studio

### DOWNLOAD

- Visit [visualstudio.microsoft.com/downloads](https://visualstudio.microsoft.com/downloads) and download the `Visual Studio Installer`.

### INSTALLATION

- Launch Visual Studio Setup named `VisualStudioSetup`
- Wait for download to complete and install the `Visual Studio Installer`
- Too many tools in the list but start with the first option `ASP.NET and web development`
- Click `Install` located at bottom right.
- It will start installing `Visual Studio Community 2022(or latest version)` with the selected components.
