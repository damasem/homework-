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

                //while (m.Success)
                //{
                //    Console.WriteLine("{0}: {1}", m.Index, m.Value);
                //    m = m.NextMatch();
                //}
                if (m.Success & l <= 12 & l >= 4)
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