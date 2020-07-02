using System;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int height;

            height = Int32.Parse(Console.ReadLine());

            var pyramid = CreateAsciiPyramid(height);
            Console.WriteLine(pyramid);
        }

        public static string CreateAsciiPyramid(int height)
        {
            char symbol = '*';
            string result = "";

            for(int i = 0; i < height; i++)
            {
                result += new string(' ', height - i - 1);

                for (int j = 0; j < i + 1; j++)
                {
                    result += symbol;
                }

                if(i != height - 1)
                {
                    result += "\n";
                }
            }

            return result;
        }
    }
}
