using System;

namespace _2_задание
{
   
    public class MyList<T>
    {
        int size;
        public  int Size { get => size; }
        T[] mass;
        public T[] Mass { get => mass;}
        public MyList()
        {
            size = 0;
            mass = new T[Size];
        }
        public void Add (T value)
        {
            size++;
            Array.Resize(ref mass, Mass.Length + 1);
            mass[mass.Length - 1] = value;
        }
        public T FindElemById(int id)
        {
            return mass[id];
        }

            
    }
    public static class Extention
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.Mass;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10000);
            myList.Add(20000);
            Console.WriteLine(myList.FindElemById(0));
            Console.WriteLine(myList.FindElemById(1));
            Console.WriteLine(myList.Size);
            myList.Add(30000);
            Console.WriteLine(myList.FindElemById(2));
            foreach(object obj in myList.GetArray())
            {
                Console.WriteLine(obj);
            }
        }
    }
}
