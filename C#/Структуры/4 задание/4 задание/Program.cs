using System;

namespace _4_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            int day;
            int res;
            Console.WriteLine("Введите число и месяц рождения: ");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(DateTime.Now.Year, month, day);
            if(date > DateTime.Now)
                res = (date - DateTime.Now).Days;
            else
                res = (new DateTime(DateTime.Now.Year + 1, month, day) - DateTime.Now).Days;
            Console.WriteLine("До следуйщего дня рождения осталось: " + res + " дня(ей)");
        }
    }
}
