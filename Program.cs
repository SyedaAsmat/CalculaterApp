using System;

namespace CalculatorAppUsingNetCon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 10;
            Calculator calc = new Calculator();
            Console.WriteLine("Calculator App\na: {0}\nb: {1}",a,b);
            int add = calc.Add(a,b);
            int sub = calc.Sub(a,b);
            int mul = calc.Mul(a,b);
            int div = calc.Div(a,b);
            Console.WriteLine("a + b = " + add);
            Console.WriteLine("a - b = " + sub);
            Console.WriteLine("a * b = " + mul);
            Console.WriteLine("a / b = " + div);
        }
    }
}
