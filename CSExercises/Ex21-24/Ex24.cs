using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            double N;
            double Nestimate;

           Console.WriteLine("Please input a number to find its square root.");
            N = Convert.ToInt16(Console.ReadLine());

            if (N >= 0)
            {
                Nestimate = Math.Round(Convert.ToDouble(N), 5);
                int E = Convert.ToInt16(N);
                Double Guess = r.Next(1, E);
                double Guessestimate = Math.Round(Guess, 5);

                while (Guessestimate != Nestimate)
                {
                    Guess = ((Guess + (N / Guess)) / 2);
                    Guessestimate = Math.Round((Guess * Guess), 5);
                }
                Guess = Math.Round(Guess, 5);
                Console.Write("The square root of  " + N);
                Console.Write("  is  " + Guess);
                string exit = Console.ReadLine();
            }
            else { Console.WriteLine("invalid input"); string exit=Console.ReadLine();}

        }
    }
}
