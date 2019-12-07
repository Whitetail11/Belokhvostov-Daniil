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
    
    class Point
    {
        int x;
        int y;
        string name;

        public int X { get => x; }
        public int Y { get => y; }
        public string Name { get => name; }
        public Point(int x, int y, string s)
        {
            this.x = x;
            this.y = y;
            this.name = s;
        }
    }
    class Figure
    {
        double Perimetr;

        public Figure(Point A, Point B, Point C)
        {
           Perimetr = LenghtSide(A, B) + LenghtSide(B, C) + LenghtSide(C, A);
            Console.WriteLine("Треугольник. Периметр = " + Perimetr);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            Perimetr = LenghtSide(A, B) + LenghtSide(B, C) + LenghtSide(C, D) + LenghtSide(D,A);
            Console.WriteLine("Квадрат. Периметр = " + Perimetr);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            Perimetr = LenghtSide(A, B) + LenghtSide(B, C) + LenghtSide(C, D) + LenghtSide(D,E)+LenghtSide(E,A);
            Console.WriteLine("Пятиугольник. Периметр = " + Perimetr);
        }
        double LenghtSide(Point A, Point B)
        {
            double Lenght;
            Lenght = Math.Sqrt(Math.Pow((A.X - B.X),2) + Math.Pow((A.Y - B.Y),2));
            return Lenght;
        }
        //void PerimetrCalculator() Понятия не имею, как это применить в коде(в том виде, как оно дано в условии задания)
        //Уточню на встрече
        //{

        //}
    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    
    class User
    {
        string login;
        string name;
        string second_name;
        int age;
        readonly DateTime date;

        public string Login { get => login; set => login = value; }
        public string Name { get => name; set => name = value; }
        public string Second_name { get => second_name; set => second_name = value; }
        public int Age { get => age; set => age = value; }
        public  DateTime Date { get => date; }
        public User(/*string login, string name, string second_name, int age*/)
        {
            //this.login = login;
            //this.name = name;
            //this.second_name = second_name;
            //this.age = age;
            date = DateTime.Now;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Логин - " + login);
            Console.WriteLine("Имя - " + name);
            Console.WriteLine("Фамилия - " + second_name);
            Console.WriteLine("Возраст - " + age);
            Console.WriteLine("Дата заполнения  - " + date);

        }
    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
   
    class Converter
    {
        double USD;
        double EUR;
        double RUB;
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public void ConvertToUSD(double grn)
        {
           
            double res = grn / USD;
            Console.WriteLine(grn + " grn в долларх " + res);
            
        }
        public void ConvertToEUR(double grn)
        {
            
            double res = grn / EUR;
            Console.WriteLine(grn + " grn в евро " + res);

        }
        public void ConvertToRUB(double grn)
        {
            
            double res = grn / RUB;
            Console.WriteLine(grn + " grn в рублях " + res);

        }
        public void ConvertToGRN(double usd, double eur, double rub)
        {
            //
            double res1 = usd * USD;
            double res2 = eur * EUR;
            double res3 = rub * RUB;

            Console.WriteLine(usd + " usd в гривнах " + res1);
            Console.WriteLine(eur + " eur в гривнах " + res2);
            Console.WriteLine(rub + " rub в гривнах " + res3);
        }
        
    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    
    class Employee
    {
        string name;
        string second_name;
        string position;
        double experience;
        public Employee(string name, string second_name)
        {
            this.name = name;
            this.second_name = second_name;
        }

        public string Name { get => name;}
        public string Second_name { get => second_name;}
        public string Position { get => position; set => position = value; }
        public double Experience { get => experience; set => experience = value; }

        public void Calculator()// 3 позиции: 1) junior 2) middle 3) senior
        {
            double BaseSalary = 0;
            double tax = 0;
            const double coefficientforjun = 2.8;
            const double coefficientformid = 3.14;
            const double coefficientforsen = 9.2;
            const double coefficientoftax = 0.18;

            if (position == "junior" && experience <= 1)
            {
                BaseSalary = 1000;
                tax = BaseSalary * coefficientoftax;
            }
            else
            {
                if (position == "junior" && experience <= 2)
                {
                    BaseSalary = 1000;
                    BaseSalary *= coefficientforjun;
                    tax = (BaseSalary * coefficientoftax);
                }
            }
            if (position == "middle" && experience <= 1)
            {
                BaseSalary = 2000;
                tax = BaseSalary * coefficientoftax;
            }
            else
            {
                if (position == "middle" && experience <= 2)
                {
                    BaseSalary = 2000;
                    BaseSalary *= coefficientformid;
                    tax = (BaseSalary * coefficientoftax);
                }
            }
            if (position == "senior" && experience <= 1)
            {
                BaseSalary = 3000;
                tax = BaseSalary * coefficientoftax;
            }
            else
            {
                if(position == "senior" && experience <= 2)
                {
                    BaseSalary = 3000;
                    BaseSalary *= coefficientforsen;
                    tax = BaseSalary * coefficientoftax;
                }
            }
            Console.WriteLine(name + ' ' + second_name + ' ' + "Ваш оклад = " + BaseSalary + " Ваш налог = " + tax);
        }
    }
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    
    class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;
        string article;
        int quantity;
        public Invoice(int account, string customer,string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        public void calculatorNDS(double cost)
        {
            double result = quantity * cost;
            Console.WriteLine("Стоимость с НДС будет состовлять - " + (result * 0.80) + " Стоимость без НДС будет состовлять - " + result);
        }

    }
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
            Console.WriteLine("Выход");
            
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
                    case 4:
                        Console.Clear();
                        Point A = new Point(2, 2, "A");
                        Point B = new Point(4, 6, "B");
                        Point C = new Point(3, 1, "C");
                        Point D = new Point(5, 2, "D");
                        Point E = new Point(2, 4, "E");
                        Figure tr = new Figure(A,B,C);
                        Figure kv = new Figure(A, B, C, D);
                        Figure fv = new Figure(A, B, C, D, E);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        User user = new User();
                        Console.WriteLine("Введите логин");
                        user.Login = Console.ReadLine();
                        Console.WriteLine("Введите имя");
                        user.Name = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        user.Second_name = Console.ReadLine();
                        Console.WriteLine("Введите ваш возраст");
                        user.Age = Convert.ToInt32(Console.ReadLine());
                        user.ShowInfo();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Введите курс доллара");
                        double usd = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите курс евро");
                        double eur = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите курс рубля");
                        double rub = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите кол-во гривен");
                        double grn = Convert.ToDouble(Console.ReadLine());
                        Converter converter = new Converter(usd, eur, rub);
                        converter.ConvertToEUR(grn);
                        converter.ConvertToUSD(grn);
                        converter.ConvertToRUB(grn);
                        converter.ConvertToGRN(30,30,30);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Введите ваше имя ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите вашу фамилию");
                        string second_name = Console.ReadLine();
                        Employee employee = new Employee(name, second_name);
                        Console.WriteLine("Введите вашу должность должность (junior,middle,senior)");
                        employee.Position = Console.ReadLine();
                        Console.WriteLine("Введите ваш стаж (1,2 года)");
                        employee.Experience = Convert.ToDouble(Console.ReadLine());
                        employee.Calculator();
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Invoice invoice = new Invoice(1,"Danya","Sasha","PC",2);
                        invoice.calculatorNDS(1000);
                        Console.ReadKey();
                        break;
                    case 9:
                        
                        break;
                    default:
                        Console.WriteLine("Incorrect number");
                        Console.ReadKey();
                        break;
                }
            } while (choose != 9);
        }
    }
}
