using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите данные");
            string userString = Console.ReadLine();
            Console.WriteLine(Transliteration.Front(userString));
            Console.ReadKey();
        }
    }
}
