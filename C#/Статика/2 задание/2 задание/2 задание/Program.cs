using System;

namespace _2_задание
{

    public static class sort
    {
        public static int[] Sort(this int[] mass, bool turn)
        {
            if(turn==true)
            for (int i = 0; i < mass.Length - 1; i++)
                for(int j = 0; j < (mass.Length - i - 1); j++)
                {
                    if(mass[j] > mass[j+1])
                    {
                        int temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
            else
                for (int i = 0; i < mass.Length - 1; i++)
                    for (int j = 0; j < (mass.Length - i - 1); j++)
                    {
                        if (mass[j] < mass[j + 1])
                        {
                            int temp = mass[j];
                            mass[j] = mass[j + 1];
                            mass[j + 1] = temp;
                        }
                    }
            return mass;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            for(int i = 0; i < 10; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Массив до сортировки : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mass[i] + " ");
            }
            mass.Sort(false);
            Console.WriteLine("\n Массив после сортировки по убыванию : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mass[i] + " ");
            }
            mass.Sort(true);
            Console.WriteLine("\n Массив после сортировки по возрастанию : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
