using System;

namespace _1_задание
{
    static class Calculator
    {
        static public double Sum(double a, double b)
        {
            return (a + b);
        }
        static public double Diff(double a, double b)
        {
            return (a - b);
        }
        static public double Dob(double a, double b)
        {
            return (a * b);
        }
        static public double Div(double a, double b)
        {
            return (a / b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Sum(32,32));
            Console.WriteLine(Calculator.Diff(40, 20));
            Console.WriteLine(Calculator.Dob(4, 6));
            Console.WriteLine(Calculator.Div(24, 6));

        }
    }
}
