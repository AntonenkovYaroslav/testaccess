using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAcces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число 5 нахуй ");
            int b = Console.Read();
            Console.Write(b);
            Console.ReadLine();
            if (b == 5)
            {
                Console.WriteLine("Я ЕБАЛ ВАШУ ХУЙНЮ ЕБАННУЮ БЛЯТЬ");
            }
            else {
                Console.WriteLine("Даун?");
            }
            Console.ReadKey();
        }
    }
}
