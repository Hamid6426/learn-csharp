# 01 - Setup and Tooling

## Prerequisites

- Basic computer knowledge

## DOWNLOAD

- Visit [code.visualstudio.com](https://code.visualstudio.com) and download VSCode for your operating system.
- Visit [dotnet.microsoft.com/download](https://dotnet.microsoft.com/en-us/download) and download the .NET SDK x64 (or a compatible version for your hardware).

## INSTALLATION

### VSCODE

1. Run the VSCode installer and follow the on-screen prompts
2. Complete the installation process
3. (Optional) Install the C# extension from the Extensions marketplace for enhanced C# support
4. Verify by clicking the Windows key and start typing `Visual Studio Code`, it will show up eventually. Click the application to launch it

### .NET SDK

1. Run the installer and follow the on-screen prompts
2. Complete the installation process
3. Verify the installation by opening PowerShell, typing `dotnet` and hit enter.

## Extensions

Install the `C# Dev Kit`, and `.NET Install Tool` extension from the VS Code extensions marketplace.

## Create a Project

### Using Terminal

1. Create a folder for your project (example: `new_dotnet_project`)
2. Open terminal and navigate to the folder: `cd new_dotnet_project`
3. Create a new console application: `dotnet new console`
4. Better way is to `dotnet new console -n new_dotnet_project` to create a new folder with the project name and avoid cluttering the current directory with project files
5. By the way, Dotnet prefer PascalCase for project names, so it will automatically convert the name to `NewDotnetProject` and create a folder with that name

### Using Command Palette

1. Open VSCode and open the Command Palette (Ctrl+Shift+P)
2. Type `> .NET: New Project` and select it
3. Choose `Console Application` from the list of templates
4. Follow the prompts to select the project location and name
5. After the project is created, open the terminal in VSCode and run `dotnet run` to execute the application

## Console App Project Structure

```
new_dotnet_project
├── obj
│   ├── new_dotnet_project.csproj.nuget.dgspec.json
│   ├── new_dotnet_project.csproj.nuget.g.props
│   ├── new_dotnet_project.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
├── new_dotnet_project.csproj
├── Program.cs
```

### Other Project Files and Directories

**Core Project Files:**

- `.csproj` - XML-based project file that contains build configuration, dependencies, and project metadata for the .NET application
- `Program.cs` - Entry point of the C# application containing the Main method

**Build Artifacts Directory (`obj/`):**

- `.csproj.nuget.dgspec.json` - NuGet dependency graph specification file containing resolved package dependencies
- `.csproj.nuget.g.props` - Auto-generated NuGet properties file with package paths and build settings
- `.csproj.nuget.g.targets` - Auto-generated NuGet targets file defining build tasks and imports
- `project.assets.json` - Lock file containing exact versions of all resolved NuGet packages and their dependencies
- `project.nuget.cache` - Cache file for NuGet package metadata to speed up restore operations

**Compiled Output Directory (`bin/`):**

- Contains the final compiled executable and runtime files after building the project

## Build and Run the Project

1. Go to the project directory: `cd new_dotnet_project`
2. Build the project by running: `dotnet build`

#### Folder structure after building the project:

```
new_dotnet_project
├── new_dotnet_project.csproj
├── Program.cs
├── obj
│   ├── new_dotnet_project.csproj.nuget.dgspec.json
│   ├── new_dotnet_project.csproj.nuget.g.props
│   ├── new_dotnet_project.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
└── bin
    └── Debug
        └── net10.0
            ├── new_dotnet_project.dll
            ├── new_dotnet_project.pdb
            └── new_dotnet_project.runtimeconfig.json
```

3. Run the project by running: `dotnet run`

## Without Building

We can also run the project without explicitly building it first, as `dotnet run` will automatically build the project if necessary. Just navigate to the project directory and execute:

### Clean and Rebuild the Project

1. To clean the project, run: `dotnet clean`
2. To rebuild the project, run: `dotnet build`
3. Re-run the project, execute: `dotnet run`
