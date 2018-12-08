using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFinal01
{
    class Program
    {
        static void Main(string[] args)
        {
       
            const string text = "57898765678909876";
            CoountLitersOnString metodCount = new CoountLitersOnString();//created method count liters, he work ONLY Console, dont  work with other methods output. Input can be different liters, number and symbol
            metodCount.MetodCoountLitersOnString(text);
                }
    }
}   
