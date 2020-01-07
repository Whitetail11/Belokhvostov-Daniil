using System;

namespace _6_задание
{
    enum Positions
    {
        director = 240,
        employe = 220,
        marketer = 300
    }
    class Accauntant
    {
        public bool AskForBonus(Positions worker, int hours)
        {
            switch (worker)
            {
                case Positions.director:
                    if (hours > Convert.ToInt32(Positions.director))
                        return true;
                    break;
                case Positions.employe:
                    if (hours > Convert.ToInt32(Positions.employe))
                        return true;
                    break;
                case Positions.marketer:
                    if (hours > Convert.ToInt32(Positions.marketer))
                        return true;
                    break;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant obj = new Accauntant();
            Console.WriteLine("Выберите должность: ");
            Console.WriteLine("1. Директор ");
            Console.WriteLine("2. Сотрудник ");
            Console.WriteLine("3. Маркетолог ");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество отработаных часов: ");
            int hours =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                   Console.WriteLine(obj.AskForBonus(Positions.director, hours));
                    break;
                case 2:
                    Console.WriteLine(obj.AskForBonus(Positions.employe, hours));
                    break;
                case 3:
                    Console.WriteLine(obj.AskForBonus(Positions.marketer, hours));
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
        }
    }
}
