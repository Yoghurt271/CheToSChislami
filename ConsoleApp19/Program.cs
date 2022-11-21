using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");
            try
            {
                Zadan();
            }
            catch
            {
                Console.WriteLine("Введите в консоль цифры!!!!");
                Zadan();
            }
            Console.ReadLine();
        }

        static void Zadan()
        {
            var n = Convert.ToInt64(Console.ReadLine());
            var n1 = n;
            var k = 0;
            while (n > 9)
            {
                n /= 10;
            }

            while (n1 > 0)
            {
                if (n1 % 10 == n)
                {
                    k++;
                    n1 /= 10;
                }
                else
                {
                    n1 /= 10;
                }
            }
            Console.WriteLine("Первая цифра чиcла равна: " + n);
            Console.WriteLine("Количество повторений первой цифры: " + k);
        }
    }
}
