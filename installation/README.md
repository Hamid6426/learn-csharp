# .NET and VSCode Setup

## Prerequisites

### DOTNET

Visit [dotnet.microsoft.com/download](https://dotnet.microsoft.com/en-us/download) and download the .NET SDK x64 (or a compatible version for your hardware).

### VSCODE

Visit [code.visualstudio.com](https://code.visualstudio.com) and download VSCode for your operating system.

## Installation Steps

### .NET SDK

1. Run the installer and follow the on-screen prompts
2. Complete the installation process
3. Verify the installation by opening PowerShell and running:

```sh
dotnet
```

4. Press Enter and confirm the .NET CLI information is displayed

### VSCode

1. Run the VSCode installer and follow the on-screen prompts
2. Complete the installation process
3. (Optional) Install the C# extension from the Extensions marketplace for enhanced C# support
4. Verify by clicking the Windows key and start typing `Visual Studio Code`, it will show up eventually. Click the application to launch it

## Extensions

Install the `C# Dev Kit`, and `.NET Install Tool` extension from the VS Code extensions marketplace.

## Create a New Project

1. Create a folder for your project (example: `01_new_dotnet_project`)
2. Open terminal and navigate to the folder: `cd 01_new_dotnet_project`
3. Create a new console application: `dotnet new console`
4. Better way is to `dotnet new console -n 01_new_dotnet_project` to create a new folder with the project name and avoid cluttering the current directory with project files
5. By the way, Dotnet prefer PascalCase for project names, so it will automatically convert the name to `01NewDotnetProject` and create a folder with that name

**Expected output:**

```sh
PS C:\Users\Hamid\OneDrive\Desktop\GITHUB\Hamid6426\learning-csharp\01_new_dotnet_project> dotnet new console
The template "Console App" was created successfully.

Processing post-creation actions...
Restoring C:\Users\Hamid\OneDrive\Desktop\GITHUB\Hamid6426\learning-csharp\01_new_dotnet_project\01_new_dotnet_project.csproj:
Restore succeeded.
```

Project will include the following files:

```sh
01_new_dotnet_project
├── obj
│   ├── 01_new_dotnet_project.csproj.nuget.dgspec.json
│   ├── 01_new_dotnet_project.csproj.nuget.g.props
│   ├── 01_new_dotnet_project.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
├── 01_new_dotnet_project.csproj
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

1. Go to the project directory: `cd 01_new_dotnet_project`
2. Build the project by running: `dotnet build`

### After running the project, you should see the following output in the terminal:

```sh
PS C:\Users\Hamid\OneDrive\Desktop\GITHUB\Hamid6426\learning-csharp\01_new_dotnet_project> dotnet build
Restore complete (0.4s)
  01_new_dotnet_project net10.0 succeeded (3.7s) → bin\Debug\net10.0\01_new_dotnet_project.dll

Build succeeded in 4.7s
```

#### Folder structure after building the project:

```sh
01_new_dotnet_project
├── 01_new_dotnet_project.csproj
├── Program.cs
├── obj
│   ├── 01_new_dotnet_project.csproj.nuget.dgspec.json
│   ├── 01_new_dotnet_project.csproj.nuget.g.props
│   ├── 01_new_dotnet_project.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
└── bin
    └── Debug
        └── net10.0
            ├── 01_new_dotnet_project.dll
            ├── 01_new_dotnet_project.pdb
            └── 01_new_dotnet_project.runtimeconfig.json
```

3. Run the project by running: `dotnet run`

### After running the project, you should see the following output in the terminal:

```shPS C:\Users\Hamid\OneDrive\Desktop\GITHUB\Hamid6426\learning-csharp\01_new_dotnet_project> dotnet run
Hello, World!
```

## Without Building

We can also run the project without explicitly building it first, as `dotnet run` will automatically build the project if necessary. Just navigate to the project directory and execute:

```sh
dotnet run ./Program.cs
```

### Creating a New Project with Command Pallete

1. Open VSCode and open the Command Palette (Ctrl+Shift+P)
2. Type `> .NET: New Project` and select it
3. Choose `Console Application` from the list of templates
4. Follow the prompts to select the project location and name
5. After the project is created, open the terminal in VSCode and run `dotnet run` to execute the application

## Installing Packages e.g. Pastel

### Using Terminal

1. Open the terminal in VSCode
2. Navigate to the project directory: `cd 01_new_dotnet_project`
3. Install the Pastel package: `dotnet add package Pastel`

### Using Command Palette

1. Open the Command Palette (Ctrl+Shift+P)
2. Type `> .NET: Add Package` and select it
3. Enter the package name (e.g., `Pastel`) and select the desired version
4. The package will be added to your project, and you can start using it in your code files

### Code Example Using Pastel

```csharp
using Pastel;

Console.WriteLine("Hello, World!".Pastel("#FF6633"));
```

### Clean and Rebuild the Project

1. To clean the project, run: `dotnet clean`
2. To rebuild the project, run: `dotnet build`

### Run the Project

1. To run the project, execute: `dotnet run`

### Expected Output

```sh
C:\Users\Hamid\OneDrive\Desktop\GITHUB\Hamid6426\learning-csharp\01_new_dotnet_project> dotnet run
Hello, World!
```
