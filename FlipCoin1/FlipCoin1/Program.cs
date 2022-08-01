using System;

namespace FlipCoin1
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

            }

            int percentageofHead = (heads/chances) * 100;
            int percentageofTails = (tails/chances) * 100;
            Console.WriteLine("Chances = " + chances);
                    Console.WriteLine("Heads: = " + heads+" percentage of heads are: "+percentageofHead);
                    Console.WriteLine("Tails: =" + tails + " percentage of tails are: " + percentageofTails);
                
            }
        }
    
}
