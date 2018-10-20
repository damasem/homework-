using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork201018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraytest = { 2, 3, 4, 5 };
            int newvaluemain = 5;
            Stack.pop(arraytest);
            Stack.Push(arraytest, newvaluemain);
        }
    }
}
