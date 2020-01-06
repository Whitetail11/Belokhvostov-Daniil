using System;

namespace _2_задание
{
    struct Train
    {
        string destination;
        int numberoftrain;
        DateTime time;
        public Train(string destination, int numberoftrain)
        {
            time = DateTime.Now;
            this.destination = destination;
            this.numberoftrain = numberoftrain;
        }
        public void showinfo()
        {
            Console.WriteLine("Пункт назначения : " + destination + ". Номер : " + numberoftrain + ". Время отправления : " + time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string destination;
            Train[] trains = new Train[8];
            for(int i = 0; i < 8; i++)
            {
                Console.WriteLine("Введите пункт назначения " + (i+1) + "-го поезда :");
                destination = Console.ReadLine();
                trains[i] = new Train(destination,i+1);
            }
            Console.WriteLine("Введите номер поезда, информацио о котором вы хотите узнать:  ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 8)
                trains[number - 1].showinfo();
            else
                Console.WriteLine("Поездов с таким номером нет!");
        }
    }
}
