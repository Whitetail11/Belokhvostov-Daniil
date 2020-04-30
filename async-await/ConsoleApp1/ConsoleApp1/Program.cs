using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double[] vector1 = new double[30000];
        static double[,] matrix1 = new double[30000, 30000];
        static double[] result1 = new double[30000];
        static double[] vector = new double[30000];
        static double[,] matrix = new double[30000, 30000];
        static double[] result = new double[30000];
        static void DobMatrix()
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                result1[i] = 0;
                for (int j = 0; j < vector1.Length; j++)
                {
                    matrix1[i, j] = 600;
                    vector1[j] = 600;
                    result1[i] += matrix1[i, j] * vector1[j];
                }
            }
        }
        static async void DobMatrixAsync()
        {
            await Task.Run(() => DobMatrix());
        }
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            DobMatrixAsync();
            //DobMatrix();
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = 0;
                for (int j = 0; j < vector.Length; j++)
                {
                    matrix[i, j] = 600;
                    vector[j] = 600;
                    result[i] += matrix[i, j] * vector[j];
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " sec");
        }
    }
}
