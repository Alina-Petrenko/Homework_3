using System;

namespace Homework_3
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Homework 3.
        /// </summary>
        /// <param name="args">console call params.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, write array length");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            Random rand = new ();
            int even = 0, odd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 26);
                if (array[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            int[] evenArray = new int[even];
            int[] oddArray = new int[odd];
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    int number = array[i];
                    evenArray[evenCount] = number;
                    evenCount++;
                }
                else
                {
                    int number = array[i];
                    oddArray[oddCount] = number;
                    oddCount++;
                }
            }

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int evenUpper = 0;
            string evenAplphabet = string.Empty;
            for (int i = 0; i < evenArray.Length; i++)
            {
                int number = evenArray[i];
                string letter = alphabet[number - 1].ToString();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "d" || letter == "h")
                {
                    evenAplphabet += letter.ToUpper();
                    evenUpper++;
                }
                else
                {
                    evenAplphabet += letter;
                }
            }

            int oddUpper = 0;
            string oddAplphabet = string.Empty;
            for (int i = 0; i < oddArray.Length; i++)
            {
                int number = oddArray[i];
                string letter = alphabet[number - 1].ToString();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "d" || letter == "h")
                {
                    oddAplphabet += letter.ToUpper();
                    oddUpper++;
                }
                else
                {
                    oddAplphabet += letter;
                }
            }

            if (evenUpper > oddUpper)
            {
                Console.WriteLine("There are more even values in upper case: " + evenUpper);
            }
            else if (evenUpper < oddUpper)
            {
                Console.WriteLine("There are more odd values in upper case: " + oddUpper);
            }
            else
            {
                Console.WriteLine("Equals values in upper case");
            }

            string evenResult = string.Empty;
            for (int i = 0; i < evenAplphabet.Length; i++)
            {
                evenResult += evenAplphabet[i] + " ";
            }

            string oddResult = string.Empty;
            for (int i = 0; i < oddAplphabet.Length; i++)
            {
                oddResult += oddAplphabet[i] + " ";
            }

            Console.WriteLine("Even array: " + evenResult);
            Console.WriteLine("Odd array: " + oddResult);
        }
    }
}
