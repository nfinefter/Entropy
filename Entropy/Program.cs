﻿using System;

namespace Entropy
{
    class Program
    {
        public static string Compressor(string input)
        {
            string compressedString = "";

            for (int i = 0; i < input.Length; i++)
            {
                int unique = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        unique++;
                    }
                    compressedString += (input[i] + unique);
                }
            }
            return compressedString;
        }
        public static string DeCompressor(string input)
        {
            string compressedString = "";
            for (int i = 1; i < input.Length; i+=2)
            {
                
            }
            return compressedString;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give a string!");
            string input = Console.ReadLine();

            Console.WriteLine(Compressor(input));

            Console.WriteLine("Give a string and numbers ex: a2b1c4");
            input = Console.ReadLine(); 

            Console.WriteLine(DeCompressor(input));

        }
    }
}
