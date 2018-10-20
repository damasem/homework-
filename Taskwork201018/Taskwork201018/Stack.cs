using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork201018
{
    public static class Stack
    {
            
        public static int Push(int[] arraytest,int newvalue)// помещает обьект  в стек
        {
           // newvalue = Console.Read();
            int[] newarray;
            int k = 1;
            newarray[0]= newvalue;
            for (int i = 2; i < newarray.Count(); i++)
            {
                arraytest[k] = newarray[i];
            }
                     
            return 0;
        }

       public static int GetHead(int[] numbers)// дает возможность увидеть первый элемент
        {
            Console.WriteLine(numbers[0]);
            return 0;
        }
        public static int Resize(int[] arraytest)// переписать размерность стека
        {
            int i = 0;
            int k;
            if (arraytest[i]> k)
            {
                Array.Resize(ref key, i);


            }
            return 0;
        }
       public static int Size(int[] arraytest)// узать размерность стека 
        {
            arraytest = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in arraytest)
            {
                Console.WriteLine(i);
            }
            return 0;
        }
        internal static void pop(int[] arraytest)// выбрасывает данные из стека
        {
            if (Size == 0)
            {
                throw new NotImplementedException();
            }
        }
    }
}
