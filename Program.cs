using system;

namespace CalculatorApp
{
  class Program
  {
    static void Main(string[ ] args)
    {
      Console.WriteLine("Калькулятор С#);
      Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
      Console.WriteLine($"10 - 4 = {Calculator.Substract(10, 4)}");
      Console.WriteLine($"6 * 7 = {Calculator.Multyply(6, 7)}");
      Console.WriteLine($"20 / 5 = {Calculator.Divide(20, 5)}");
      Console.WriteLine($"2 ^ 3 = {Calculator.Power(2, 3)}");
    }
  }
}
