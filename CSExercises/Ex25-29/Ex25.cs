using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int F,i;
            int Answer = 1;
           

            Console.WriteLine("enter the integer you wish to perform Factorial.");
            F = Convert.ToInt16(Console.ReadLine());

            if (F>=0)
            { 
                Answer = 1; //reset
                for (i = 1; i <= F; i++)
                {
                    Answer = Answer * i ;

                }
                Console.WriteLine("Using increment counter...");
                Console.Write("the factorial of  " + F);
                Console.Write(" is " + Answer);
                string exit = Console.ReadLine();

                Answer = 1;//reset

                for (i = F; i >= 1; i--) 
                {
                    Answer = Answer * i;
                }
                Console.WriteLine("using decrement counter...");
                Console.Write("The factorial of  " + F);
                Console.Write("  is  " + Answer);
               string exit1 = Console.ReadLine();
           
            }
            else// negative numbers
            {
                Console.WriteLine("**Error** wrong input given");
                string exit = Console.ReadLine();
            }


        }
    }
}
