
using System;
using System.Text;


namespace task_DEV_3
{/// <summary>
 /// Class for converting numbers from decimal system to
 /// other numeral systems
 /// </summary>

    class ConverterToAnotherNumeralBase
    {
        public int currentDecimalNumber;
        public int requiredBase;
        private int temporaryNumber;

        /// <summary>
        /// Method,where we create string and then
        /// add the remainder of the dividing our
        /// decimal number by system base
        /// </summary>
        public string BaseConverting()
        {
            StringBuilder convertingResult = new StringBuilder();
            temporaryNumber = Math.Abs(currentDecimalNumber); //We need it if our number will negative(for add "-")

            while (temporaryNumber != 0) //Until we'll finish the division
            {
                const string baseSymbols = "0123456789ABCDEFGHIJ";
                convertingResult.Append(baseSymbols[temporaryNumber % requiredBase]);
                temporaryNumber = temporaryNumber / requiredBase;
            }

            if (currentDecimalNumber < 0) //If the decimal number is negative we'll add the '-' to it
            {
                convertingResult.Append('-');
            }

            //Reversing of our converting result with using of StringBuilder
            StringBuilder convertingResultReverse = new StringBuilder();
            for (int i = convertingResult.Length - 1; i >= 0; i--)
            {
                convertingResultReverse.Append(convertingResult[i]); //Adding elements from the last to the first element of our convert result string
            }
            return convertingResultReverse.ToString();
        }
    }
}
