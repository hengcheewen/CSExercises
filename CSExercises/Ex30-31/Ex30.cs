using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            
            int count;
            for (int i = 5; i <= 1000; i++ )
            {
                count = 0;
                for (int j= 1; j <= i; j++)
                {
                    if (i % j == 0) { count = count + 1; }
                }
                if (count == 2)
                { Console.Write(i); Console.Write(" is a prime number.");
                Console.WriteLine();
                }
                
            }
            string exit = Console.ReadLine();
        }
    }
}
