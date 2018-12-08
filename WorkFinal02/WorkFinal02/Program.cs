using System;
using System.Net;

namespace WorkFinal02
{
    class Program
    {
        static void Main(string[] args)
            
        {
         string IP_String = "";
            IPAddress ip;

            ValidationIPaddres validateIPadress = new ValidationIPaddres();
            ReturnIPAdressWithDifString IpFind = new ReturnIPAdressWithDifString();

            validateIPadress.MetodValidationIPaddres(IP_String);

            if (validateIPadress.ValidateStringTrue == false)
            {
                
                Console.Write("Wrong ip");
            }
            else if (validateIPadress.ValidateStringTrue == true)
            {
                if (!IPAddress.TryParse(IP_String, out ip)) { Console.Write("Wrong ip now"); }
                IpFind.MetodReturnIPAdressWithDifStrin(IP_String);
            }



            Console.ReadLine();


        }
    }
}
