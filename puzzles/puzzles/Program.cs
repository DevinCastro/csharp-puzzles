using System;
using System.Linq;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] randNums = new int[10];
            Random rand = new Random();

            for (int i = 0; i < randNums.Length; i++)
            {
                randNums[i] = rand.Next(5, 26); // 26 will not be included, only to 25
                Console.WriteLine(randNums[i]);
            }

            Console.WriteLine("Max: " + randNums.Max());
            Console.WriteLine("Min: " + randNums.Min());
            Console.WriteLine("Sum: " + randNums.Sum());

            return randNums;
        }

       

        static void Main(string[] args)
        {
            RandomArray();
            Console.ReadLine();
        }
    }
}
