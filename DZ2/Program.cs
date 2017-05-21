using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Введите числа для получения их суммы (через пробел)");
            string [] arr=Console.ReadLine().Split();
            int sum = 0;
            foreach(var item in arr)
            {
                try
                {
                    sum = sum +Int32.Parse(item);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                
               // sum = sum + Int32.Parse(item); это был первый вариант, который вылетал при вводе фигни
            }
            Console.WriteLine("Сумма введённых чисел равна {0}",sum);
        }
    }
}
