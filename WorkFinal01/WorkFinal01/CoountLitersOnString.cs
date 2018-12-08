using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFinal01
{
   public class CoountLitersOnString
    {

        public void MetodCoountLitersOnString(String text){
           foreach (var letter in text.Distinct().ToArray())
            {
                var count = text.Count(chr => chr == letter);
        Console.WriteLine("Количество символов {0} = {1}", letter, count);
            }
}

}
}

