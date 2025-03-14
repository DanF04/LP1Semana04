﻿using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            char character = char.Parse(args[1]);
            int number = int.Parse(args[2]);

            Console.WriteLine(Decor(args[0],character,number));
        }

        private static string Decor(string s, char dec, int space)
        {
            string decs = "";
            for (int i = 0; i<space; i++)
            {
                decs += dec;
            }

            return $"{decs} {s} {decs}";
        }
    }
}
