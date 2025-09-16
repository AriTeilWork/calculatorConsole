class CalculatorUI
{
    private Calculator calculator;

    public CalculatorUI(Calculator calc)
    {
        calculator = calc;
    }

    public void Start()
    {
        while (true)
        {
            ShowMenu();
            string choice = Console.ReadLine();

            if (choice == "5") break;

            double num1 = ReadNumber("Enter first number: ");
            double num2 = ReadNumber("Enter second number: ");

            PerformAction(choice, num1, num2);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    private void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Object-Oriented Console Calculator ===");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
    }

    private double ReadNumber(string prompt)
    {
        Console.Write(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }

    private void PerformAction(string choice, double num1, double num2)
    {
        try
        {
            double result = choice switch
            {
                "1" => calculator.Add(num1, num2),
                "2" => calculator.Subtract(num1, num2),
                "3" => calculator.Multiply(num1, num2),
                "4" => calculator.Divide(num1, num2),
                _ => throw new InvalidOperationException("Invalid choice.")
            };

            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}