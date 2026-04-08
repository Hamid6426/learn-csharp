Lab 08 - Grade Analyzer

Review the uncommented code below and identify areas that would benefit from documentation. Consider:

- What business logic needs explanation?
- Which methods would benefit from XML documentation?
- Where would inline comments add genuine value?

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
namespace GradeAnalyzer
{
    public class GradeStatistics
    {
        private List<double> grades;
        
        public GradeStatistics()
        {
            grades = new List<double>();
        }
        
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }
        
        public double CalculateAverage()
        {
            if (grades.Count == 0) return 0;
            return grades.Sum() / grades.Count;
        }
        
        public double CalculateStandardDeviation()
        {
            if (grades.Count <= 1) return 0;
            
            double average = CalculateAverage();
            double sumOfSquaredDeviations = 0;
            
            foreach (double grade in grades)
            {
                double deviation = grade - average;
                sumOfSquaredDeviations += deviation * deviation;
            }
            
            return Math.Sqrt(sumOfSquaredDeviations / (grades.Count - 1));
        }
        
        public string GenerateGradeDistribution()
        {
            if (grades.Count == 0) return "No grades available";
            
            int aCount = grades.Count(g => g >= 90);
            int bCount = grades.Count(g => g >= 80 && g < 90);
            int cCount = grades.Count(g => g >= 70 && g < 80);
            int dCount = grades.Count(g => g >= 60 && g < 70);
            int fCount = grades.Count(g => g < 60);
            
            return $"Grade Distribution:\nA: {aCount}\nB: {bCount}\nC: {cCount}\nD: {dCount}\nF: {fCount}";
        }
        
        public List<double> GetGradesAboveAverage()
        {
            double average = CalculateAverage();
            return grades.Where(g => g > average).ToList();
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            GradeStatistics stats = new GradeStatistics();
            
            stats.AddGrade(95);
            stats.AddGrade(87);
            stats.AddGrade(92);
            stats.AddGrade(78);
            stats.AddGrade(85);
            stats.AddGrade(91);
            stats.AddGrade(88);
            
            Console.WriteLine($"Average: {stats.CalculateAverage():F2}");
            Console.WriteLine($"Standard Deviation: {stats.CalculateStandardDeviation():F2}");
            Console.WriteLine(stats.GenerateGradeDistribution());
            
            var aboveAverage = stats.GetGradesAboveAverage();
            Console.WriteLine($"Grades above average: {string.Join(", ", aboveAverage)}");
        }
    }
}
```

## Tip

Don't comment every line—focus on areas where your explanation adds genuine value for future developers.

## Common Mistakes

- Adding obvious comments like `// Create new list` for `grades = new List<double>();`
- Explaining syntax instead of business logic
- Forgetting to update comments when code changes

---

Create a comprehensive file header that includes:

- File purpose and description
  -Author information
- Creation and modification dates
- Key dependencies and business context

## Tip

Think about what information a new team member would need to understand this file's role in the larger application.

---

Add XML documentation comments for all public methods, including:

- Clear method summaries explaining purpose and behavior
- Parameter descriptions with expected ranges or formats
- Return value explanations
- Usage examples for complex methods

## Tip

Focus on the method's purpose and any non-obvious behavior, like how it handles edge cases.

## Common Mistakes

- Writing generic descriptions like "This method calculates something"
- Forgetting to document parameters and return values
- Not explaining important business rules or constraints

---

Include inline comments that explain:

- Mathematical formulas and their business significance
- Complex business logic that isn't obvious from variable names
- Edge case handling and validation rules
- Performance considerations or algorithmic choices

## Tip

Ask yourself: "What would I want to know about this code if I encountered it six months from now?"

---

Review your commented code to ensure:

- All comments add genuine value rather than restating obvious code
- XML documentation is complete and accurate
- Inline comments explain "why" rather than just "what"
- Professional tone and formatting throughout

## Success Checklist

- File header provides a comprehensive context about the code's purpose
- All public methods have complete XML documentation (summary, parameters, returns)
- Inline comments explain business logic and mathematical formulas
- Standard deviation calculation includes explanation of the statistical approach
- Grade distribution logic is documented with business context
- Comments follow professional formatting and tone standards
- No redundant or obvious comments that don't add value

## Key Points

- Professional documentation explains business logic, not just syntax
- XML documentation should help other developers use your methods correctly
- Comments are most valuable when they explain reasoning and context
- Good variable and method names reduce the need for extensive commenting

---

## UNDERSTANDING

### Inline Comments

To simplify, inline comments are required in this format

[what is happening] `because` [why it’s needed] `to` [what it achieves]

Example:

```csharp
grades.Add(grade);
// [Add grade to list] `because` [we need to store grades] `to` [calculate statistics]

grades.Sum() / grades.Count;
// [Calculate average] `because` [we need to calculate the average of the grades] `to` [get the average grade]

Math.Sqrt(sumOfSquaredDeviations / (grades.Count - 1));
// [Calculate standard deviation] `because` [we need to calculate the standard deviation of the grades] `to` [get the standard deviation of the grades]
```

### File Header Documentation

File header documentation is required in this format, any field deemed useful can be included. Fields are not required to be in this order. Must have fields are File, Purpose, Author and Created(Creation Date).

```csharp
/*
 * File: [filename]
 * Purpose: [purpose of the file]
 * Author: [author name]
 * Created: [creation date]
 * Last Modified: [last modification date]
 * Description: [description of the file]
 * Dependencies: [dependencies of the file]
 */
```

### XML Documentation

XML documentation is required in this format, any field deemed useful can be included. Fields are not required to be in this order. Must have fields are Summary, Parameters, Returns, Remarks,

Example:

```csharp
/// <summary>
/// [summary of the method]
/// </summary>
/// <param name="[parameter name]"> [description of the parameter] </param>
/// <returns> [description of the return value] </returns>
/// <remarks> [remarks of the method] </remarks>
/// <example>
/// <code>
/// [code example of the method]
/// </code>
/// </example>
```