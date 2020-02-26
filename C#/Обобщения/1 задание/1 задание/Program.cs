using System;

namespace _1_задание
{
    class MyClass<T> where T: struct
    {
       public static T GetT()
        {
            T value = default(T);
            return value;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //MyClass<int> myClass = new MyClass<int>();
            Console.WriteLine(MyClass<int>.GetT().GetType());


            //MyClass<double> myClass1 = new MyClass<double>();
            Console.WriteLine(MyClass<double>.GetT());
        }
    }
}
