using System;

namespace BetterDecorador
{
    /// <summary>
    /// Using the method Decor that returns a string with a x number of chars in each side,
    /// it prints in the main method, the user input in args, according to the variables needed
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The programs main method
        /// </summary>
        /// <param name="args">prints the method Decor using the user input in args</param>
        private static void Main(string[] args)
        {
            char character = char.Parse(args[1]);
            int number = int.Parse(args[2]);

            Console.WriteLine(Decor(args[0],character,number));
        }

        /// <summary>
        /// Adds to a string depending on the int number
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="space"></param>
        /// <returns>a string containing the text surrounded by the symbols amount</returns>
        private static string Decor(string s, char dec, int space)
        {
            string decs = "";
            for (int i = 0; i<space; i++)
            {
                decs += dec;
            }

            return $"{decs} {s} {decs}";
        }

        private static string Decor()
        {
            string s2 = "User did not specify args!";
            char dec2 = '=';
            int space2 = 3;
            string dec3 = "";

            for (int i = 0; i<space2; i++)
            {
                dec3 += dec2;
            }

            return $"{dec3} {s2} {dec3}";
        }
    }
}
