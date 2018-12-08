using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork3
{
   
    class Arbitrary : Triangle
    {
        public override void GetSquare(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double Square;

            if (p >= 0)
                Square = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            //if (x == 1)
           // {
               
           //}
            //else if (Successor != null)
           // {
            //    Successor.GetSquare(x,y,z);
           // }
        }
    }
}
