Console.WriteLine("=======================================");
Console.WriteLine("    Financial Calculator v1.0");
Console.WriteLine("=======================================");
Console.WriteLine("This calculator performs basic arithmetic operations");
Console.WriteLine("and demonstrates operator precedence for financial calculations.");

Console.WriteLine(); // Empty line for readability

Console.WriteLine("Put the first amount:");
string input1 = Console.ReadLine(); // Read user first input
if (!decimal.TryParse(input1, out decimal amount1))
{
  Console.WriteLine("Invalid input. Please enter a valid decimal number.");
  Console.WriteLine("Put the first amount:");
  input1 = Console.ReadLine(); // Read user first input again
}

Console.WriteLine("Enter the operation (+, -, *, /, %):");
string operation = Console.ReadLine(); // Read user operation input

if (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "%")
{
  Console.WriteLine("Invalid operation. Please use +, -, *, /, or %. or 'CTRL + C' to exit.");
  Console.WriteLine("Enter the operation (+, -, *, /, %):");
  operation = Console.ReadLine(); // Read user operation input again 
}

Console.WriteLine("Put the second amount:");
string input2 = Console.ReadLine(); // Read user second input
if (!decimal.TryParse(input2, out decimal amount2))
{
  Console.WriteLine("Invalid input. Please enter a valid decimal number.");
  Console.WriteLine("Put the second amount:");
  input2 = Console.ReadLine(); // Read user second input again
}

// convert into decimal
decimal amount1 = decimal.Parse(input1);
decimal amount2 = decimal.Parse(input2);

decimal sum = 0, difference = 0, product = 0, quotient = 0, remainder = 0; // Declare variables for results

if (amount2 != 0) // Check for division by zero
{
  // Proceed with calculations
  if (operation == "+")
  {
    sum = amount1 + amount2;
    Console.WriteLine($"Sum: ${sum:F2}");
  }
  else if (operation == "-")
  {
    difference = amount1 - amount2;
    Console.WriteLine($"Difference: ${difference:F2}");
  }
  else if (operation == "*")
  {
    product = amount1 * amount2;
    Console.WriteLine($"Product: ${product:F2}");
  }
  else if (operation == "/")
  {
    quotient = amount1 / amount2;
    Console.WriteLine($"Quotient: ${quotient:F2}");
  }
  else if (operation == "%")
  {
    remainder = amount1 % amount2;
    Console.WriteLine($"Remainder: ${remainder:F2}");
  }
  else
  {
    Console.WriteLine("Invalid operation. Please use +, -, *, /, or %.");
  }
}
else
{
  Console.WriteLine("The second amount cannot be zero for division or modulus operations.");
}

// continue after the first operation

Console.WriteLine(); // Empty line for readability

Console.WriteLine("Continue the operations? (Y/n)");

Console.WriteLine("Great! Input the next operation (+, -, *, /, %):");

string nextOperation = Console.ReadLine();

if (nextOperation != "+" && nextOperation != "-" && nextOperation != "*" && nextOperation != "/" && nextOperation != "%")
{
  Console.WriteLine("Invalid operation. Please use +, -, *, /, or %. or 'CTRL + C' to exit.");
  Console.WriteLine("Great! Input the next operation (+, -, *, /, %):");
  nextOperation = Console.ReadLine(); // Read user operation input again
}

Console.WriteLine("Input the next amount:");
string continueInput = Console.ReadLine();
if (!decimal.TryParse(continueInput, out decimal nextAmount))
{
  Console.WriteLine("Invalid input. Please enter a valid decimal number.");
  Console.WriteLine("Input the next amount:");
  continueInput = Console.ReadLine(); // Read user second input again
}

if (continueInput == "y")
{
  Console.WriteLine("Put the next amount:");
  string nextInput = Console.ReadLine();
  decimal nextAmount = decimal.Parse(nextInput);

  if (nextOperation == "+")
  {
    sum += nextAmount;
    Console.WriteLine($"Updated Sum: ${sum:F2}");
  }
  else if (nextOperation == "-")
  {
    difference -= nextAmount;
    Console.WriteLine($"Updated Difference: ${difference:F2}");
  }
  else if (nextOperation == "*")
  {
    product *= nextAmount;
    Console.WriteLine($"Updated Product: ${product:F2}");
  }
  else if (nextOperation == "/")
  {
    if (nextAmount != 0)
    {
      quotient /= nextAmount;
      Console.WriteLine($"Updated Quotient: ${quotient:F2}");
    }
    else
    {
      Console.WriteLine("Cannot divide by zero.");
    }
  }
  else if (nextOperation == "%")
  {
    if (nextAmount != 0)
    {
      remainder %= nextAmount;
      Console.WriteLine($"Updated Remainder: ${remainder:F2}");
    }
    else
    {
      Console.WriteLine("Cannot perform modulus with zero.");
    }
  }
  else
  {
    Console.WriteLine("Invalid operation. Please use +, -, *, /, or %.");
  }
}
else
{
  Console.WriteLine("Thank you for using the Financial Calculator!");
}