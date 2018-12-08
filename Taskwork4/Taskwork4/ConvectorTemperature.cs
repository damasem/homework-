using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskwork4
{
    class ConvectorTemperature
    {
        public double results;
        public void GetCovesctorM(double value, string from, string tois)
        {


        }if ( from == "g" && tois == "fu")
            {
                results = value* 0.0022046;
            }
            if (from == "fu" && tois == "g"){
                results = value* 453.59243;
            }
            if (from == "pd" && tois == "g")
            {
                results = value* 16379.987;
            }
            if (from == "g" && tois == "pd")
            {
                results = value* 16380.687;
            }
            if (from == "fu" && tois == "pd")
            {
                results = value* 40;
            }
            if (from == "pd" && tois == "fu")
            {
                results = value* 36.113;
            }
    }
}
