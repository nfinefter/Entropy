using System;

namespace Entropy
{
    class Program
    {
        public static string Compressor(string input)
        {
            string compressedString = "";

            for (int i = 0; i < input.Length; i++)
            {
                int count = 1;

                while (i + 1 < input.Length && input[i] == input[i + 1])
                {
                    count++;
                    i++;
                }
                compressedString += input[i] + count.ToString();
            }
            return compressedString;
        }
        public static string DeCompressor(string input)
        {
            string compressedString = "";
            

            for (int i = 0; i < input.Length; i+= 2)
            {
                char character = input[i];
                int digit = (int)char.GetNumericValue(input[i + 1]);

                for (int j = 0; j < digit; j++)
                {
                    compressedString += character;
                }    

                
            }
            return compressedString;
        }

        static Random rand = new Random();

        static string CreateRandomString(int length)
        {
            string randomString = "";

            for (int i = 0; i < length; i++)
            {
                int randomCharacter = rand.Next('A', 'z' + 1);
                randomString += (char)randomCharacter;
            }

            return randomString;
        }

        static void TestEntropy(int iterations, int length)
        {
            for (int i = 0; i < iterations; i++)
            {
                string input = CreateRandomString(length);
                string compressed = Compressor(input);
                string deCompressed = DeCompressor(compressed);

                if (deCompressed != input)
                {
                    throw new Exception("Did not work");
                }
            }
        }

        static void Main(string[] args)
        {
            TestEntropy(1000, 15);
        }
    }
}
