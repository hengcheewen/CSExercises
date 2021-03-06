using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                Console.Write("\n   Square root of {0} up to 5dp is {1} ", i, SQT(i));// execute method SQT for int 1 to 25
            }
            string exit = Console.ReadLine();
        }

        public static double SQT(int y)
        {
            //Finding square root a given number using a random number between 1 and the given number itself
            Random r = new Random();
            double N;
            double G;
            double Nestimate;

            // Console.WriteLine("Please enter the integer number you want to perform squareroot.");
            N = Convert.ToDouble(y);
            if (N >= 0)
            {
                Nestimate = Math.Round(Convert.ToDouble(N), 5); //estimate 
                int E = Convert.ToInt16(N);
                G = r.Next(1, E);//remember that Next(a,b) means inclusive of a but exclusive of b
                double Gestimate = Math.Round(G, 5); //estimate G from random numbers to 5 decimal places

                while (Gestimate != Nestimate)
                {
                    G = (G + N / G) / 2;
                    //Console.WriteLine(" G =" + G); debug code to check iteration progress Remove when ok.
                    Gestimate = Math.Round((G * G), 5);
                }
                G = Math.Round(G, 5);
                // Console.Write("The square root of " + N);
                // Console.Write(" is " + G);
                // Console.Write("\n The intrinsic squareroot [math.Sqrt()] answer is  {0:0.00000}", Math.Sqrt(N));

                // string exit = Console.ReadLine();
                return G;
            }
            else
            {
                // Console.WriteLine("Invalid input"); string exit = Console.ReadLine();
                G = 0;
                return G; //dont understand
            }

            }
       
    }
}
