namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basik calculator");
            Calculator calc = new Calculator();
            CalculatorUI ui = new CalculatorUI(calc);
            ui.Start();
        }

    }
}
