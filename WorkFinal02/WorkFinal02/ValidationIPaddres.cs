using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkFinal02
{
    class ValidationIPaddres
    { 
        public Boolean ValidateStringTrue = false;
        public void MetodValidationIPaddres(string IP_String)
        {

            try
            {
             
                Regex r = new Regex(@"[0-9,.]+"); //It does not correspond to any digit, exclamation mark, grid, space.
                Match m = r.Match(IP_String);
                int l = IP_String.Length;
                
               
                if (m.Success & l <= 16 & l >= 8)
                {
                    ValidateStringTrue = true;
                }
                else
                {
                    ValidateStringTrue = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("It does not correspond.");


            }

        }
    }

}