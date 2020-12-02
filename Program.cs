using System;
using System.Linq;

namespace AOC_2020_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 2020;

            string[] lines = System.IO.File.ReadAllLines(@"D1.txt");

            int[] numbers = Array.ConvertAll<string, int>(lines, new Converter<string, int>(i => int.Parse(i)));

            foreach (int number in numbers)
            {
                int num1 = number;
                
                foreach (int num in numbers)
                {
                    int num2 = num;
                    int twoNums = num1 + num2;

                    if (twoNums < target)
                    {
                        int complement = target - twoNums;
                        if (numbers.Contains(complement))
                        {
                            Console.WriteLine($"Answer found is {num1} * {num2} * {complement} equals {num1 * num2 * complement}!");
                            return;
                        }
                    }
                }
            }
        }
    }
}
