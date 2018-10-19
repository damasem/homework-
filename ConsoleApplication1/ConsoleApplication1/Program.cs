using System;
using System.Linq;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите данные");
            string userString = Console.ReadLine();
            char[] c = userString.ToCharArray();
            var g = c.GroupBy(i => i);
            Console.WriteLine("count: " + g.Count());
            foreach (var k in g)
                Console.WriteLine(k.Key + " (" + k.Count() + ")");
            Console.ReadKey();
        }
    }
}
