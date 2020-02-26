using System;

namespace _7_задание
{
    class MyArrayList
    {
        int size;
        object[] mass;

        public int Size { get => size; }

        public MyArrayList()
        {
            size = 0;
            mass = new object[size];
        }

        public void Add(object value)
        {
            size++;
            Array.Resize(ref mass, mass.Length + 1);
            mass[mass.Length - 1] = value;
        }

        public object GetElemById(int id)
        {
            return mass[id];
        }

        public void ShowElem()
        {
            foreach(object obj in mass)
            {
                Console.WriteLine(obj);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            list.Add(123);
            list.Add("Hello");
            list.Add(2.4);

            list.ShowElem();

            Console.WriteLine(list.Size);
        }
    }
}
