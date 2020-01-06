using System;

namespace _3_задание
{
    class MyClass
    {
        public string change;
    }
    struct MyStrutc
    {
        public string change;
    }


    class Program
    {
        static void ClassTaker(MyClass Class)
        {
            Class.change = "changed";
        }
        static void StructTaker(MyStrutc Struct)
        {
            Struct.change = "changed";
        }
        static void Main(string[] args)
        {
            MyClass Class = new MyClass();
            MyStrutc Struct;
            Class.change = "not changed";
            Struct.change = "not changed";
            ClassTaker(Class);
            StructTaker(Struct);
            Console.WriteLine(Class.change);
            Console.WriteLine(Struct.change);
        }
    }
}

//Структура передает в качестве параметра в функцию не ссылку на обьект, а его копию, копия меняется,
//а обьект остаётся таким же, если мы поставим в методе ref MyStruct Struct и укажем ref Struct при передаче параметра,
//тогда эффект будет таким же, как и с Class
