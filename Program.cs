using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {

        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(3);
            Names();
        }

        //Random Array
        //Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray()
        {
            //Place 10 random integer values between 5-25 into the array
            Random rand = new Random();
            int[] randomArr = new int[10];

            for(int i = 0; i < 10; i++)
            {
                randomArr[i] = rand.Next(5, 25);
            }
            Console.WriteLine(String.Join(", ", randomArr));
            //Print the min and max values of the array
            //Print the sum of all the values
            int max = randomArr[0];
            int min = randomArr[0];
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                sum = sum + randomArr[i];
                if(randomArr[i] > max)
                {
                    max = randomArr[i];
                }
                if(randomArr[i] < min)
                {
                    min = randomArr[i];
                }
            }
            Console.WriteLine($"Min: {min} Max: {max} Sum: {sum}");
            return randomArr;
        }
        //Coin Flip
        //Create a function called TossCoin() that returns a string
        public static string TossCoin()
        {
            //Have the function print "Tossing a Coin!"
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string coinStr = "Tossing a Coin!";
            Console.WriteLine(coinStr);
            //Randomize a coin toss with a result signaling either side of the coin
            Random rand = new Random();
            int toss = rand.Next(1,3);
            //Have the function print either "Heads" or "Tails"
            //Finally, return the result
            string result = (toss == 1) ? "heads" : "tails";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(result);

            return result;
        }
        //Create another function called TossMultipleCoins(int num) that returns a Double
        public static double TossMultipleCoins(int num)
        {
            //Have the function call the tossCoin function multiple times based on num value
            //Have the function return a Double that reflects the ratio of head toss to total toss
            double heads = 0;
            double tails = 0;
            for (int i = 0; i < num; i++)
            {
                string outcome = TossCoin();
                if (outcome == "heads")
                {
                    heads ++;
                }
                else
                {
                    tails ++;
                }
            }
            double ratio = heads / tails;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ratio: {heads} heads to {tails} tails in {num} tosses is {ratio}");

            return ratio;

        }
        //Names
        //Build a function Names that returns a list of strings.  In this function:
        public static List<string> Names()
        {
            //Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            List<string> ogList = new List<string>();
            ogList.Add("Todd");
            ogList.Add("Tiffany");
            ogList.Add("Charlie");
            ogList.Add("Geneva");
            ogList.Add("Sydney");

            //Shuffle the list and print the values in the new order
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Return a list that only includes names longer than 5 characters
            List<string> longList = new List<string>();

            for(int i = 0; i < ogList.Count; i++)
            {
                ogList[i] = ogList[rand.Next(5)];
                Console.WriteLine(ogList[i]);
                if(ogList[i].Length > 5)
                {
                    longList.Add(ogList[i]);
                    
                }
               
            }
            Console.WriteLine(String.Join(", ",longList));
            return longList;
        }

    
    }
}
