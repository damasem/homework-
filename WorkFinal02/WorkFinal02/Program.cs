using System;
using System.Net;

namespace WorkFinal02
{
    class Program
    {
        static void Main(string[] args)
            
        {
         string IP_String = "256.100.100.1";
            IPAddress ip;

            ValidationIPaddres validateIPadress = new ValidationIPaddres();
            ReturnIPAdressWithDifString IpFind = new ReturnIPAdressWithDifString();

            validateIPadress.MetodValidationIPaddres(IP_String);

            if (validateIPadress.ValidateStringTrue == false) //first there is a check on the liquidity of the entered values
            {
                
                Console.Write("Wrong ip");
            }
            else if (validateIPadress.ValidateStringTrue == true) //Then there is a check directly on reality Ip
            {
                if (!IPAddress.TryParse(IP_String, out ip)) { Console.Write("Wrong ip now"); }
                IpFind.MetodReturnIPAdressWithDifStrin(IP_String);
            }



            Console.ReadLine();


        }
    }
}
