using System;

namespace _1_задание
{
    struct Notebook
    {
        string model;
        string manufacturer;
        double cost;
        public Notebook(string model, string manufacturer, double cost)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.cost = cost;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Модель ноутбука : " + model + ". Производитель : " + manufacturer + ". Цена : " + cost + " грн.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("AX570", "Asus", 2200);
            notebook.ShowInfo();
        }
    }
}
