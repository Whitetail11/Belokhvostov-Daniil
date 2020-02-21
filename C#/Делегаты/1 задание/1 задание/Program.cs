using System;

namespace _1_задание
{
    class Program
    {
        delegate double MyDelegate(double x, double y, double z);
        static void Main(string[] args)
        {
            MyDelegate avarange = delegate (double x, double y, double z)
            {
                return (x + y + z) / 3;
            };
            double result = avarange(10, 5, 6);
            Console.WriteLine(result);
        }
    }
}
