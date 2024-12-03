using System;
using Tyuiu.ShutnikovaST.Lab2.Review.V12.Lib;

namespace Tyuiu.ShutnikovaST.Lab2.TaskReview.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = " Выполнила: Шутникова С.Т. | МКМб-22-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("******************************************************************************");
            Console.Write("Старт шага = ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конец шага = ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            double[] results = ds.GetMassFunction(start, end);
            for (int x = 0; x < results.Length; x++)
            {
                int i = start + x;
                string fx = results[x].ToString();
                Console.WriteLine($"| {i,8} | {fx,8} |");
            }
            Console.ReadKey();
        }
    }
}