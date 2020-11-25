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

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int num = rand.Next(0,2);
            //Console.WriteLine(num);
            
            if (num == 0)
            {
                return "Heads";
            } else
            {
                return "Tails";
            }

        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            double ratio = 0.0;
     

            for (int i = 0; i < num; i++)
            {
                //TossCoin();
                if (TossCoin() == "Heads")
                {
                    heads++;
                } else
                {
                    tails++;
                }
            }
            try
            {
                ratio = heads / tails;
           
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("All Heads, No Tails.");
            }

            Console.WriteLine(heads + " / " + tails);
            return ratio;

        }
       

        static void Main(string[] args)
        {
            Console.WriteLine(TossMultipleCoins(5000));
            // RandomArray();
            Console.ReadLine();
        }
    }
}
