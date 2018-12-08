using System;


namespace WorkFinal02
{
    class ReturnIPAdressWithDifString
    {
        
        public void MetodReturnIPAdressWithDifStrin(String IP_string) {
            
            
            try
            {
                String[] bytes = IP_string.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                IP_string = "";
                int i = 0;
                foreach (string one_byte in bytes)
                {

                    string temp = one_byte.TrimStart('0');
                    IP_string = IP_string + temp;
                    if (i < 3) IP_string = IP_string + ".";
                    i++;
                }
                Console.WriteLine("Processed IP:" + IP_string);

                Console.ReadLine();

            }
            catch ( Exception e)
            {
                Console.WriteLine(" Wrong! ");
                
                    Console.ReadLine();

            }
               
                   }
}
}