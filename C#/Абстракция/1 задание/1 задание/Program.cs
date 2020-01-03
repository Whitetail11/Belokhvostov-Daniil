using System;

namespace _1_задание
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();

    }
    class XMLHandler: AbstractHandler
    {
        override public void Open()
        {
            Console.WriteLine("Открыт файл с расширением XML ");
        }
        override public void Create()
        {
            Console.WriteLine("Создан файл с расширением XML ");
        }
        override public void Change()
        {
            Console.WriteLine("Изменен файл с расширением XML ");
        }
        override public void Save()
        {
            Console.WriteLine("Сохранён файл с расширением XML ");
        }
    }
    class TXTHandler: AbstractHandler
    {
        override public void Open()
        {
            Console.WriteLine("Открыт файл с расширением TXT ");
        }
        override public void Create()
        {
            Console.WriteLine("Создан файл с расширением TXT ");
        }
        override public void Change()
        {
            Console.WriteLine("Изменен файл с расширением TXT ");
        }
        override public void Save()
        {
            Console.WriteLine("Сохранён файл с расширением TXT ");
        }
    }
    class DOCHandler: AbstractHandler
    {
        override public void Open()
        {
            Console.WriteLine("Открыт файл с расширением DOC "); 
        }
        override public void Create()
        {
            Console.WriteLine("Создан файл с расширением DOC ");
        }
        override public void Change()
        {
            Console.WriteLine("Изменен файл с расширением DOC ");
        }
        override public void Save()
        {
            Console.WriteLine("Сохранён файл с расширением DOC ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler obj = new TXTHandler();
            obj.Create();
            obj.Open();
            obj.Change();
            obj.Save();
            AbstractHandler obj2 = new XMLHandler();
            obj2.Create();
            obj2.Open();
            obj2.Change();
            obj2.Save();
            AbstractHandler obj3 = new DOCHandler();
            obj3.Create();
            obj3.Open();
            obj3.Change();
            obj3.Save();
        }
    }
}
