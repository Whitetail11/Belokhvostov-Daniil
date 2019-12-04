using System;

namespace ConsoleApp1
{
  
    class Address
    {
        int house;
        string index;
        string city;
        string coutry;
        string street;
        int apartment;
        public int House { get => house; set => house = value; }
        public string Index { get => index; set => index = value; }
        public string City { get => city; set => city = value; }
        public string Coutry { get => coutry; set => coutry = value; }
        public string Street { get => street; set => street = value; }
        public int Apartment { get => apartment; set => apartment = value; }
        public void Showinfo()
        {
            Console.WriteLine(Index + ", " + Coutry + ", " + City + ", " + Street + ", " + House + ", " + Apartment );
        }
    }
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    class Rectangle
    {
        double side1, side2;
        public double Area { get => AreaCalculator(); }
        public double Perimetr { get => PerimetrCalculator(); }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
         double AreaCalculator()
        {
            
            return (side1 * side2);
        }
         double PerimetrCalculator()
        {
            return ((side1 + side2) * 2);
        }
    }
    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
     class Title
    {
        string name;
    public string Name { get => name; set => name = value; }

    public void show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Name);
        Console.ResetColor();
    }
}
class Author
{
    string name;

    public string Name { get => name; set => name = value; }

    public void show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Name);
        Console.ResetColor();
    }
}
class Content
{
    string name;

    public string Name { get => name; set => name = value; }

    public void show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Name);
        Console.ResetColor();
    }
}
class Book
    {
        Title TitleOfBook = new Title();
        Author AuthorOfBook = new Author();
        Content ContentOfBook = new Content();
        public void AddTitle(string title)
        {
            TitleOfBook.Name = title;
        }
        public void AddAuthor(string author)
        {
            AuthorOfBook.Name = author;
        }
        public void AddContent(string content)
        {
            ContentOfBook.Name = content;
        }
        public void ShowInfo()
        {
            TitleOfBook.show();
            AuthorOfBook.show();
            ContentOfBook.show();
        }
    }
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    class Program
    {
        static void dialoge(ref  int choose)// диалог
        {
            Console.Clear();
            Console.WriteLine("1 Задание");
            Console.WriteLine("2 Задание");
            Console.WriteLine("3 Задание");
            Console.WriteLine("4 Задание");
            Console.WriteLine("5 Задание");
            Console.WriteLine("6 Задание");
            Console.WriteLine("7 Задание");
            Console.WriteLine("8 Задание");
            Console.WriteLine("9 Задание");
            Console.WriteLine("10 Задание");
            Console.WriteLine("11 Задание");
            Console.WriteLine("12 Задание");
            choose = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choose = 0;
            do
            {
                dialoge(ref choose);
                switch (choose)
                {
                    case 1:
                        Console.Clear();
                        Address address = new Address();
                        address.Index = "49195";
                        address.Coutry = "Ukraine";
                        address.City = "Dnepr";
                        address.Street = "Evropeisky street";
                        address.House = 14;
                        address.Apartment = 142;
                        address.Showinfo();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите 2 стороны прямоугольника :");
                        double side1 = Convert.ToDouble(Console.ReadLine());
                        double side2 = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(side1, side2);
                        Console.WriteLine("Площадь = " + rectangle.Area);
                        Console.WriteLine("Периметр = " + rectangle.Perimetr);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Book book = new Book();
                        Console.WriteLine("Введите название книги:");
                        string title = Console.ReadLine();
                        book.AddTitle(title);
                        Console.WriteLine("Введите имя автора:");
                        string author = Console.ReadLine();
                        book.AddAuthor(author);
                        Console.WriteLine("Введите контент:");
                        string content = Console.ReadLine();
                        book.AddContent(content);
                        book.ShowInfo();
                        Console.ReadKey();
                        break;
                    case 13:
                        Console.WriteLine("Выход");
                        break;
                    default:
                        Console.WriteLine("Incorrect number");
                        Console.ReadKey();
                        break;
                }
            } while (choose != 13);
        }
    }
}
