using System;

namespace наследование
{
    class Printer
    {
       virtual public void print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class sonofPrinter : Printer
    {
        public override void print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    

    class ClassRoom
    {
        Pupil pupil1;
        Pupil pupil2;
        Pupil pupil3;
        Pupil pupil4;
        int counter;
        public ClassRoom(Pupil pupil1,Pupil pupil2,Pupil pupil3,Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
            counter = 4;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            counter = 3;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            counter = 2;
        }
        public void showinfo()
        {
            if(counter==4)
            {
                pupil1.study();
                pupil1.read();
                pupil1.write();
                pupil1.relax();
                pupil2.study();
                pupil2.read();
                pupil2.write();
                pupil2.relax();
                pupil3.study();
                pupil3.read();
                pupil3.write();
                pupil3.relax();
                pupil4.study();
                pupil4.read();
                pupil4.write();
                pupil4.relax();
            }
            else
            {
                Console.WriteLine("В классе маловато люедй");
            }
        }
    }
    class Pupil
    {
        virtual public void study()
        {

        }
        virtual public void read()
        {

        }
        virtual public void write()
        {

        }
        virtual public void relax()
        {

        }
    }
    class ExelentPupil : Pupil
    {
        override public void study()
        {
            Console.WriteLine("Я отличный ученик, учусь отлично");
        }
        override public void read()
        {
            Console.WriteLine("Я отличный ученик, читаю отлично");
        }
        override public void write()
        {
            Console.WriteLine("Я отличный ученик, пишу отлично");
        }
        override public void relax()
        {
            Console.WriteLine("Я отличный ученик, отдыхаю я неочень:(");
        }
    }
    class GoodPupil : Pupil
    {
        override public void study()
        {
            Console.WriteLine("Я хороший ученик, учусь хорошо");
        }
        override public void read()
        {
            Console.WriteLine("Я хороший ученик, читаю хорошо");
        }
        override public void write()
        {
            Console.WriteLine("Я хороший ученик, пишу хорошо");
        }
        override public void relax()
        {
            Console.WriteLine("Я хороший ученик, отдыхаю нормально");
        }
    }
    class BadPupil : Pupil
    {
        override public void study()
        {
            Console.WriteLine("Я плохой ученик, учусь плохо");
        }
        override public void read()
        {
            Console.WriteLine("Я плохой ученик, читаю плохо");
        }
        override public void write()
        {
            Console.WriteLine("Я плохой ученик, пишу плохо");
        }
        override public void relax()
        {
            Console.WriteLine("Я плохой ученик, отдыхаю я отлично");
        }
    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    

    class Vehicle
    {
        protected string coordinates;
        protected double cost;
        protected double speed;
        protected string year_of_issue;
        public Vehicle(string coordinates, double cost, double speed, string year_of_issue)
        {
            this.coordinates = coordinates;
            this.cost = cost;
            this.speed = speed;
            this.year_of_issue = year_of_issue;
        }
        virtual public void show_info()
        {

        }
    }
    class Plane : Vehicle
    {
        double height;
        int passagers;
        public Plane(string coordinates, double cost, double speed, string year_of_issue, double height, int passagers) : base(coordinates, cost, speed, year_of_issue)
        {
            this.height = height;
            this.passagers = passagers;
        }
        public override void show_info()
        {
            Console.WriteLine("Координаты - " + coordinates + " Стоимость - " + cost + " Скорость - " + speed + " Год выпуска - " + year_of_issue + " Высота полёта - " + height + " Кол-во пассажирова - " + passagers);
        }
    }
    class Car : Vehicle
    {
        public Car(string coordinates, double cost, double speed, string year_of_issue) : base(coordinates, cost, speed, year_of_issue)
        {

        }
        public override void show_info()
        {
            Console.WriteLine("Координаты - " + coordinates + " Стоимость - " + cost + " Скорость - " + speed + " Год выпуска - " + year_of_issue);
        }
    }
    class Ship : Vehicle
    {
        int passagers;
        string code;
        public Ship(string coordinates, double cost, double speed, string year_of_issue,int passagers,string code): base(coordinates,cost,speed,year_of_issue)
        {
            this.passagers = passagers;
            this.code = code;
        }
        public override void show_info()
        {
            Console.WriteLine("Координаты - " + coordinates + " Стоимость - " + cost + " Скорость - " + speed + " Год выпуска - " + year_of_issue + " Порт приписки - " + code  + " Кол-во пассажирова - " + passagers);
        }

    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    

    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт ");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии про ");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии про ");
        }
    }
    class ProDocumetWorker : DocumentWorker
    {
        override public void EditDocument()
        {
            Console.WriteLine("Документ отредактирован ");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт ");
        }
    }
    class ExpertDocumentWorker : ProDocumetWorker
    {
        override public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате ");
        }
    }

    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    


    class Program
    {
        static void dialoge(ref int choose)// диалог
        {
            Console.Clear();
            Console.WriteLine("1 Задание");
            Console.WriteLine("2 Задание");
            Console.WriteLine("3 Задание");
            Console.WriteLine("4 Задание");
            Console.WriteLine("Выход(5)");

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
                        Printer printer = new Printer();
                        Printer printer2 = new sonofPrinter();
                        printer.print("I am a printer");
                        printer2.print("I am son of printer");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Pupil pupil1 = new GoodPupil();
                        Pupil pupil2 = new BadPupil();
                        Pupil pupil3 = new ExelentPupil();
                        Pupil pupil4 = new BadPupil();
                        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
                        classRoom.showinfo();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Vehicle car = new Car("10:20", 1200, 140, "1994");
                        Vehicle ship = new Ship("20:10", 3000, 70, "2003", 50, "Порт прописки");
                        Vehicle plane = new Plane("30:10", 5000, 200, "2019", 13000, 40);
                        car.show_info();
                        ship.show_info();
                        plane.show_info();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введите ключ версии ");
                        string key = Console.ReadLine();
                        if(key == "Ключ от версии pro")
                        {
                            Console.WriteLine("Вам предоставлена версия про !");
                            DocumentWorker proworker = new ProDocumetWorker();
                            proworker.OpenDocument();
                            proworker.EditDocument();
                            proworker.SaveDocument();
                        }
                        else if(key=="Ключ от версии exp")
                        {
                            Console.WriteLine("Вам предоставлена версия эксперет !");
                            DocumentWorker expworker = new ExpertDocumentWorker();
                            expworker.OpenDocument();
                            expworker.EditDocument();
                            expworker.SaveDocument();
                        }
                        else
                        {
                            Console.WriteLine("Вам предоставлена обычная версия !");
                            DocumentWorker worker = new DocumentWorker();
                            worker.OpenDocument();
                            worker.EditDocument();
                            worker.SaveDocument();
                        }

                        Console.ReadKey();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Incorrect number!");
                        Console.ReadKey();
                        break;
                }
            } while (choose != 5);
        }
    }
}
