using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork3
{
    abstract class Triangle
    {
        public Triangle Successor { get; set; }
       // public interface ICreate();
        public abstract void GetSquare(double x, double y, double z);
    }
}
