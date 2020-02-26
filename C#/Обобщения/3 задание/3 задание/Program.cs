using System;

namespace _3_задание
{
    class MyDictionary<TKey, TValue> 
        where TKey: IComparable<TKey>
    {
        int size;
        public int Size { get => size; }
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            size = 0;
            keys = new TKey[size];
            values = new TValue[size];
        }
        public void Add(TKey key, TValue value)
        {
            size++;
            Array.Resize(ref keys, keys.Length + 1);
            Array.Resize(ref values, values.Length + 1);
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public TValue GetValueByKey(TKey key)
        {
            for(int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                    return values[i];
            }
            return default;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "Ноль");
            myDictionary.Add(1, "Один");
            Console.WriteLine(myDictionary.Size);
            Console.WriteLine(myDictionary.GetValueByKey(1));
        }
    }
}
