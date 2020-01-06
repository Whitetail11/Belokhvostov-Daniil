using System;
using System.Text;
namespace _4_задание
{
    public static class operation
    {
        public static string MineSubString(this string str1, int a, int b)
        {

            char[] mass = str1.ToCharArray();
            char[] res = new char[b];
            for(int i = a, j = 0; j < b; i++, j++)
            {
                res[j] = mass[i];
            }
            str1 = new string(res);
            return str1;
        }
        public static int MineIndexOf(this string str, string str1)
        {
            char[] mass = str.ToCharArray();
            char[] mass1 = str1.ToCharArray();
            int res = 404;
            for(int i = 0, j = 0; i < str.Length; i++)
            {
                if (mass[i] == mass1[j])
                {
                    res = i;
                    for (int k = i; j < str1.Length; k++, j++)
                    {
                        if (mass[k] == mass1[j])
                        {
                            if (j == str1.Length - 1)
                                return res;
                            continue;
                        }
                        else
                        {
                            j = 0;
                            res = 404;// код ошибки
                            break;
                        }
                    }   
                }

            }
            return res;
        }
        public static string MineReplace(this string str, string a, string b)
        {
            StringBuilder res = new StringBuilder(str);
            if (str.Contains(a))
            {
                res.Remove(str.MineIndexOf(a), a.Length);
                res.Insert(str.MineIndexOf(a), b);
            }
            str = res.ToString();
            return str;
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Первый метод : ");
            string test = "Прокрастинация";
            Console.WriteLine(test);
            Console.WriteLine("Результат работы моего метода : ");
            Console.WriteLine(test.MineSubString(3, test.Length - 3)); ;
            Console.WriteLine("Результат работы стандартного метода : ");
            Console.WriteLine(test.Substring(3, test.Length - 3));


            Console.WriteLine("Второй метод : ");
            string test2 = "Всем Всим Всем ";
            string res = "Всим";
            Console.WriteLine(test2);
            Console.WriteLine(res);
            Console.WriteLine("Результат работы моего метода : ");
            int indexOfSubstring = test2.MineIndexOf(res);
            Console.WriteLine(indexOfSubstring);
            Console.WriteLine("Результат работы стандартного метода : ");
            int indexOfSubstring1 = test2.IndexOf(res);
            Console.WriteLine(indexOfSubstring1);


            Console.WriteLine("Третий метод : ");
            string test3 = "Какой-то текст";
            Console.WriteLine(test3);
            Console.WriteLine("Результат работы моего метода : ");
            test3 = test3.MineReplace("текст", "поменял");
            Console.WriteLine(test3);
            Console.WriteLine("Результат работы стандартного метода : ");
            string res3 = test3.Replace("текст", "поменял");
            Console.WriteLine(res3);
            Console.ReadKey();
        }
    }
}
