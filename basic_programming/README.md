# 02 - Basics of a Program

## Entry Point

In C#, execution starts at `Main()` inside a class.

```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

Although, .NET 6+ supports top-level statements - no class or `Main()` required:

```csharp
Console.WriteLine("Hello, World!");
```

---

## Class Wrapper

Every C# file belongs to a class. The class wraps your logic.

```csharp
class MyApp
{
    static void Main()
    {
        // code here
    }
}
```

---

## Namespaces

Namespaces organize code and prevent naming conflicts.

```csharp
namespace MyProject
{
    class Program
    {
        static void Main() { }
    }
}
```

`using` imports a namespace:

```csharp
using System;
using System.Collections.Generic;
```

.NET 6+ implicit usings - common namespaces are auto-imported, no need to declare them manually.

---

## How to Run

```bash
dotnet new console -n HelloWorld
cd HelloWorld
dotnet run
```

---

## Comments

### Single-line

```csharp
// This is a single-line comment
int x = 10; // inline comment
```

### Multi-line

```csharp
/*
  This spans
  multiple lines
*/
```

### XML Doc Comments

Used by IDEs for tooltips and documentation generation.

```csharp
/// <summary>
/// Calculates the sum of two integers.
/// </summary>
/// <param name="a">First number</param>
/// <param name="b">Second number</param>
/// <returns>Sum of a and b</returns>
static int Add(int a, int b) => a + b;
```
