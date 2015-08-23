using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
             public static void Main(string[] args)
        {
            int[] CoinDenomination = new int[5] { 100, 50, 20,10, 5 };
            int[] CoinsCount = new int[5];
         

            Console.Write("Please enter the amount [between 0.05 and 3.50] :  ");
            
            double inputinitial = Convert.ToDouble(Console.ReadLine()) * 100;

            int input = Convert.ToInt16(inputinitial);
            Console.WriteLine("Coins denomination breakdowm:");

            for (int i =0; i<=4; i++)
            {
                CoinsCount[i] = input / CoinDenomination[i];
                input = input % CoinDenomination[i];                 //   bool calculated = false;
            }

            for (int i = 0 ; i<=4;i++)
            {
                if ( CoinsCount[i] != 0)
                    for (int j = 1; j <= CoinsCount[i]; j++) { Console.WriteLine(" {0}c", CoinDenomination[i]); }

            }

            string exit = Console.ReadLine();
        }
    }
}
