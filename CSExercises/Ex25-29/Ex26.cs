using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i;
            Console.WriteLine("NO\t INVERSE\t SQUARE ROOT\t SQUARE\t");
            Console.WriteLine("-----------------------------------------------");
            for (i = 1; i <= 10; i++) 
            {
                double NO = i;
                double INVERSE = 1 / NO;
                double SQUAREROOT = Math.Sqrt(NO);
                double SQUARE = (NO * NO);

                Console.WriteLine("{0:0.0}\t {1:0.000}\t\t {2:0.000}\t\t {3:0.0}\t", NO, INVERSE, SQUAREROOT, SQUARE);
            }
            string exit = Console.ReadLine();

        }
    }
}
