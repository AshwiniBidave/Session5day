using System;

namespace Flipcoin
{
    class Program
    {

        public class Toss
        {
           public String chanceFunc()
            {
                Random r = new Random();
                int chance = r.Next(2);
                if (chance == 1)
                {
                    return "tails";
                }
                else
                {
                    return "heads";
                }
            }
            public static void main(String[] args)
            {
                String
                Toss t = new Toss();
                int heads = 0;
                int tails = 0;
                int chances = 10;
                for (int i = 1; i <= chances; i++)
                {
                    if (t.chanceFunc().Equals("tails"))
                    {
                        tails++;
                    }
                    else
                    {
                        heads++;
                    }
                }
                Console.WriteLine("Chances = " + chances);
                Console.WriteLine("Heads: " + heads);
                Console.WriteLine("Tails: " + tails);
            }
        }
    }

}

