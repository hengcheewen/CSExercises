using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            
            int a;
            int b;

            Console.Write("enter a positive integer =  ");
            a = Convert.ToInt16(Console.ReadLine());

            if (a == 0 || a == 1)
            {
                Console.WriteLine(a + " is not prime number");
                string exit = Console.ReadLine();
            }

            else
            {
                for (b = 2; b <= a / 2; b++)
                {
                    if (a % b == 0)
                    {
                        Console.WriteLine(a + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(a + " is a prime number");
                string exit = Console.ReadLine();
            }
            
        }
    }
}
