using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericToWords
{
    class Program
    {
        /// <summary>
        /// string Array
        /// </summary>
        private static string[] specialNames = {
        "",
        " thousand",
        " million",
        " billion",
        " trillion",
        " quadrillion",
        " quintillion"
    };

        /// <summary>
        /// string Array
        /// </summary>
        private static string[] tensNames = {
        "",
        " ten",
        " twenty",
        " thirty",
        " forty",
        " fifty",
        " sixty",
        " seventy",
        " eighty",
        " ninety"
    };
        /// <summary>
        /// string Array
        /// </summary>
        private static string[] numNames = {
        "",
        " one",
        " two",
        " three",
        " four",
        " five",
        " six",
        " seven",
        " eight",
        " nine",
        " ten",
        " eleven",
        " twelve",
        " thirteen",
        " fourteen",
        " fifteen",
        " sixteen",
        " seventeen",
        " eighteen",
        " nineteen"
    };

        /// <summary>
        /// Method to convert numbers which are less that thousand
        /// </summary>
        /// <param name="number">Integer</param>
        /// <returns>string</returns>
        private string ConvertLessThanOneThousand(int number)
        {
            string current;

            if (number % 100 < 20)
            {
                current = numNames[number % 100];
                number /= 100;
            }
            else
            {
                current = numNames[number % 10];
                number /= 10;

                current = tensNames[number % 10] + current;
                number /= 10;
            }

            if (number == 0) return current;

            return numNames[number] + " hundred" + current;
        }

        /// <summary>
        /// Method to Convert Numbers to Words
        /// </summary>
        /// <param name="number">Integer</param>
        /// <returns>string</returns>
        public string ConvertNumberToWords(int number)
        {
            if (number == 0) { return "zero"; }

            string prefix = "";

            if (number < 0)
            {
                number = -number;
                prefix = "negative";
            }

            string current = "";
            int place = 0;

            do
            {
                int n = number % 1000;

                if (n != 0)
                {
                    string s = ConvertLessThanOneThousand(n);
                    current = s + specialNames[place] + current;
                }

                place++;
                number /= 1000;
            }

            while (number > 0);

            return (prefix + current).Trim();
        }

        /// <summary>
        /// Main Method calling the ConvertNumberToWords
        /// </summary>
        /// <param name="args">Arguments</param>
        public static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Enter a number: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(obj.ConvertNumberToWords(number));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            Console.ReadLine();
        }
    }
}
