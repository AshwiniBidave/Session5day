using System;

namespace FlipCoin

{
    class Program
    {
        public String chanceFunc()
        {
            Random r = new Random();
            int chance = r.Next(0, 2);
            if (chance == 1)
            {
                return "tails";
            }
            else
            {
                return "heads";
            }
        }
    }

    public class Toss
    {
        public static void Main(String[] args)
        {
            Program p = new Program();

            int heads = 0;
            int tails = 0;
            int chances = 10;



            for (int i = 1; i <= chances; i++)
            {
                if (p.chanceFunc().Equals("tails"))
                {
                    tails++;
                }
                else
                {
                    heads++;
                }


                Console.WriteLine("Chances = " + chances);
                Console.WriteLine("Heads: = " + heads);
                Console.WriteLine("Tails: =" + tails);
            }
        }
    }

}   


