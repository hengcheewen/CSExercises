
using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a three digit integer   ");
            int x = Convert.ToInt32(Console.ReadLine());
            if ((x > 99) && (x < 1000))

            {
                double a = x / 100;
                double a1 = Math.Floor(a);
                double b = ((x - (100 * a1)) / 10);
                double b1 = Math.Floor(b);
                double c = (x - (100 * a1) - (10 * b1));
                double y1 = (a1 * a1 * a1) + (b1 * b1 * b1) + (c * c * c);
                int y = Convert.ToInt16(y1);
                Console.WriteLine("The three digits are        " + a1 + b1 + c);
                Console.WriteLine("Summation of the individual digits cubes is    " + y);

                if (x==y)
                { Console.WriteLine("You've keyed in  an Armstrong Number" + y);
                }
                else { Console.WriteLine("This is not an Armstrong Number!"); }

                string exit = Console.ReadLine();
            }

            else
            { Console.Write("you did not enter a 3 digit number.");
            string exit = Console.ReadLine();
            
            }

        }
    }
}