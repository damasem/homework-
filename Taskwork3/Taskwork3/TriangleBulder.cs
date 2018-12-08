using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork3
{
    class TriangleBulder : Triangle
    {

        public override void GetSquare(double x, double y, double z)
        {
            double alpha = 0;
            double betta = 0;
            double gamma = 0;

            alpha = (((Math.Acos((y * y + z * z - x * x) / (2 * y * z)) * 180)) / Math.PI);
            betta = (((Math.Acos((x * x + z * z - y * y) / (2 * x * z)) * 180)) / Math.PI);
            gamma = (((Math.Acos((x * x + y * y - z * z) / (2 * x * y)) * 180)) / Math.PI);

            if ((x < y + z) & (z < y + x) & (z < y + x))
            {
                if ((alpha == 90) || (betta == 90) || (gamma == 90))
                {
                    Triangle h2 = new Rectangular();
                }
                else
               if ((alpha > 90) || (betta > 90) || (gamma > 90))
                {
                    Triangle h3 = new Equilateral();
                }
                else
                {

                }
                  //  Console.WriteLine("Треугольник остроугольный");


            }
            else
            {
                 Console.WriteLine("Теугольник не существует");
                 Console.ReadKey();

            }
               
            throw new NotImplementedException();
        }

    }
}
      

        
