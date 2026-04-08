class Program
{
  static void Main()
  {
    // Starting values for our calculator
    decimal amount1 = 1500.17m;
    decimal amount2 = 250.25m;

    // Perform arithmetic operations like sum, difference, product, quotient, and remainder
    decimal sum = amount1 + amount2;
    decimal difference = amount1 - amount2;
    decimal product = amount1 * amount2;
    decimal quotient = amount1 / amount2;
    decimal remainder = amount1 % amount2;

    // Display arithmetic results
    Console.WriteLine($"Sum: ${amount1:F2} + ${amount2:F2} = ${sum:F2}");
    Console.WriteLine($"Difference: ${amount1:F2} - ${amount2:F2} = ${difference:F2}");
    Console.WriteLine($"Product: ${amount1:F2} * ${amount2:F2} = ${product:F2}");
    Console.WriteLine($"Quotient: ${amount1:F2} / ${amount2:F2} = ${quotient:F2}");
    Console.WriteLine($"Remainder: ${amount1:F2} % ${amount2:F2} = ${remainder:F2}");

    Console.WriteLine(); // Empty line for readability

    // Perform comparison operations
    bool isGreater = amount1 > amount2;
    bool isEqual = amount1 == amount2;
    bool sumOver2000 = (amount1 + amount2) > 2000;
    bool amountOneUnder1600 = amount1 <= 1600;

    // Display comparison results
    Console.WriteLine($"Is ${amount1:F2} greater than ${amount2:F2}? {isGreater}");
    Console.WriteLine($"Is ${amount1:F2} equal to ${amount2:F2}? {isEqual}");
    Console.WriteLine($"Is the sum greater than $2000? {sumOver2000}");
    Console.WriteLine($"Is ${amount1:F2} less than or equal to $1600? {amountOneUnder1600}");
  }
}