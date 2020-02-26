using System;

namespace _5_задание
{
    class Car
    {
        string name;
        string year;

        public Car(string name, string year)
        {
            this.name = name;
            this.year = year;
        }
        public string Name { get => name; set => name = value; }
        public string Year { get => year; set => year = value; }
    }

    class CarCollection<T>
    {
        int size;

        public int Size { get => size; }
        T[] mass;
        public CarCollection()
        {
            size = 0;
            mass = new T[size];
        }
        public void Add(T car)
        {
            size++;
            Array.Resize(ref mass, mass.Length + 1);
            mass[mass.Length - 1] = car;
        }
        public T GetElemById(int id)
        {
            return mass[id];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();
            Car car1 = new Car("Volvo", "1900");
            Car car2 = new Car("BMW", "1800");
            Car car3 = new Car("MAZDA", "2000");

            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);

            Console.WriteLine(cars.GetElemById(0).Year);
            Console.WriteLine(cars.Size);
        }
    }
}
