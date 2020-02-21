using System;

namespace _3_задание
{
    public delegate int RandomNumberDelegate();
    public delegate int MyDelegate(RandomNumberDelegate[] rnd);
    class Program
    {
        
        static void Main(string[] args)
        {
            RandomNumberDelegate[] rnd = new RandomNumberDelegate[10];
            for(int i = 0; i < rnd.Length; i++)
            {
                rnd[i] = () =>
                {
                    Random num = new Random();
                    int n = num.Next(10, 101);
                    return n;
                };
            }
            MyDelegate del = rnd =>
            {
                int avarange = 0;
                for (int i = 0; i < rnd.Length; i++)
                {
                    avarange += rnd[i].Invoke();
                }
                avarange = avarange / 10;
                return avarange;
            };

            Console.WriteLine(del(rnd));
        }
    }
}
