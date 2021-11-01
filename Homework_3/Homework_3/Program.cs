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
            Console.WriteLine("Please, write rang of array");
            int value = int.Parse(Console.ReadLine());
            int[] array = new int[value];
            Random rand = new Random();
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

            Console.WriteLine("array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int[] evenArray = new int[even];
            int[] oddArray = new int[odd];
            int j = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    int number = array[i];
                    evenArray[j] = number;
                    j++;
                }
                else
                {
                    int number = array[i];
                    oddArray[k] = number;
                    k++;
                }
            }

            string evenAplphabet = string.Empty;
            string oddAplphabet = string.Empty;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < evenArray.Length; i++)
            {
                int number = evenArray[i];
                if (alphabet[number - 1].ToString() == "a" || alphabet[number - 1].ToString() == "e" || alphabet[number - 1].ToString() == "i" || alphabet[number - 1].ToString() == "d" || alphabet[number - 1].ToString() == "h")
                {
                    evenAplphabet += alphabet[number - 1].ToString().ToUpper();
                }
                else
                {
                    evenAplphabet += alphabet[number - 1];
                }
            }

            for (int i = 0; i < oddArray.Length; i++)
            {
                int number = oddArray[i];
                oddAplphabet += alphabet[number - 1];
            }

            Console.WriteLine(evenAplphabet);
            Console.WriteLine("even");
            foreach (int i in evenArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("odd");
            foreach (int i in oddArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
