using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int input = int.Parse(Console.ReadLine());
            // 0, 1, 1, 3, 5, 11, 21, 43, 85, 171, 341, ...
            
            Console.WriteLine(GetSpecial(input));
            
        }

        private static int GetSpecial (int n)
        {
            if (n < 2)
            {
                return n;
            }

            else 
            return GetSpecial(n-1) + (2 * GetSpecial(n-2));
            

        }
    }
}
