using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Formula : y = 2X^2 - 4X + 3");
            Console.Write(" Enter a value of X =  ");
            int x = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("X\t Y\t");
            for (x = -5;  x < 5; x++) 
            { 
            int y = 2 * x * x - (4 * x) + 3;
            
            Console.WriteLine("{0:0.0}\t {1:0.0}\t", x, y);
            }
            string exit = Console.ReadLine();
        }
    }
}
