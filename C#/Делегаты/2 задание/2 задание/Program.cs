using System;

namespace _2_задание
{
    class Program
    {
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            Operation Add = (x, y) => x + y;
            Operation Sub = (x, y) => x - y;
            Operation Mul = (x, y) => x * y;
            Operation Div = (x, y) =>
            {
                if (y != 0)
                    return x / y;
                else
                    return 0;
            };
            Console.WriteLine("Выберите оператор для чисел 21 и 7 : \n 1. Add\n 2. Sub\n 3. Mul\n 4. Div\n 5. Exit");
            int choose;
            double res = 0;
            do
            {
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        res = Add(21, 7);
                        Console.WriteLine("Result = " + res);
                        break;
                    case 2:
                        res = Sub(21, 7);
                        Console.WriteLine("Result = " + res);
                        break;
                    case 3:
                        res = Mul(21, 7);
                        Console.WriteLine("Result = " + res);
                        break;
                    case 4:
                        res = Div(21, 7);
                        Console.WriteLine("Result = " + res);
                        break;
                    default:
                        break;
                }
            } while (choose != 5);
            Console.ReadKey();
        }
    }
}
