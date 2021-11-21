using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность отрицательных и положительных чисел.");
            Console.WriteLine("Для окончания последовательности введите 0");
            int n;
            int sumMinys = 0;
            int sumPlus = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    sumPlus += 1;
                }
                if (n < 0)
                {
                    sumMinys += 1;
                }
            } while (n != 0);

            Console.WriteLine("Количество отрицательных чисел {0}", sumMinys);

            Console.WriteLine("Количество положительных чисел {0}", sumPlus);

            Console.ReadKey();
        }
    }
}
