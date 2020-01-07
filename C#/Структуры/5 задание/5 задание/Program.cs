using System;

namespace _5_задание
{
    enum colors
    {
        red = 1,
        blue = 2,
        green = 3
    }
    static class operation
    {

        /// <summary>
        /// //////////////////////////////////////////////////////////
        /// </summary> В голову пришла только такая реализация, как по мне проще не использовать перечисление и просто
        /// через switch относительно color выбирать цвет... Может я чего-то не понимаю О_О
        public static void Print(string stroka, int color)
        {
            if(color == Convert.ToInt32(colors.red))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if(color == Convert.ToInt32(colors.blue))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (color == Convert.ToInt32(colors.green))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите цвет строки: ");
            Console.WriteLine("1. Красный");
            Console.WriteLine("2. Синий");
            Console.WriteLine("3. Зеленый");
            int col = Convert.ToInt32(Console.ReadLine());
            operation.Print(str, col);
        }
    }
}
