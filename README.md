# calculatorConsole
ClientSide

# Console Calculator (Object-Oriented)

A simple console calculator in C#, implemented in an object-oriented style with clear class separation.

## Project Structure

- **Calculator** – contains methods for mathematical operations:
  - `Add(double a, double b)`
  - `Subtract(double a, double b)`
  - `Multiply(double a, double b)`
  - `Divide(double a, double b)`

- **CalculatorUI** – handles the console interface and user interaction:
  - Displays a menu.
  - Reads numbers from the user.
  - Executes the chosen action using the `Calculator` class.

- **Program** – entry point:
  - Creates instances of `Calculator` and `CalculatorUI`.
  - Starts the console interface.

## Features

- Addition, subtraction, multiplication, and division of numbers.
- Division by zero check.
- Console menu for selecting operations.
- Runs in a loop until the user chooses to exit.

## How to Use

1. Clone the repository or copy the files into your project.
2. Open the project in Visual Studio or another C# IDE.
3. Run the project (`F5` in Visual Studio or `dotnet run` in terminal).
4. Choose an operation from the menu.
5. Enter two numbers.
6. View the result and continue or exit.
