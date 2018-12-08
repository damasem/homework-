using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork3
{
    class Equilateral : Triangle
    {
        public override void GetSquare(double x, double y, double z)
        {                       
            double Square;

            Square = ((Math.Sqrt(3)) / 4) * Math.Pow(x, 2);

            //if (x == 1)
            //{
               
            //}
            //else if (Successor != null)
            //{
            //    Successor.GetSquare(x, y, z);
            //}
        }
    }
}
