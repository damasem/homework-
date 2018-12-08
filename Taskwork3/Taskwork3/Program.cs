using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork3
{
    class Client
    {
        void Main()
        {
            
            Triangle h1 = new Rectangular();
            Triangle h2 = new Equilateral();
            Triangle h3 = new Arbitrary();
            h1.Successor = h2;
            h1.GetSquare(2,3,5);
        }
    }
}