using System;


namespace task_DEV_3
{
    /// <summary>
    /// Program's main class.Program for converting decimal base value from command line
    /// to another base.
    /// </summary>

    class Program
    {
        const int minBase = 2;
        const int MaxBase = 20;

        static void Main(string[] args)
        {
            try
            {
                int initialNumber = Convert.ToInt32(args[0]);
                int baseOfNewNumberSystem = Convert.ToInt32(args[1]);
             
                    if (baseOfNewNumberSystem < minBase || baseOfNewNumberSystem > MaxBase)
                    {
                        throw new Exception("Base of new number is out of range (input : 2 <= new base <= 20 )");
                    }
                NumberSystemConversion numberSystemConversion = new NumberSystemConversion(baseOfNewNumberSystem);
                String convertedNumber = String.Empty;               
                convertedNumber = numberSystemConversion.ConvertIntToNewSystem(initialNumber);
                Console.WriteLine("Initial number : " + initialNumber + " was converted into new number system with base : "
                   + baseOfNewNumberSystem + " , converted number is : " + convertedNumber);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception message : " + e.Message);
                Console.ReadKey();
            }
        }
    }
}