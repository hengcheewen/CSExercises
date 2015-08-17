using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Formula : y = 2X^2 - 4X + 3");
            Console.WriteLine(" Enter a value of X =");
            double X = ISS.RV.LIB.ISSConsole.ReadDouble();
            double Y = (2 * X * X) - (4 * X) + 3;
            Console.WriteLine("therefore the answer is = " + Y);
            Console.ReadLine();


        }
    }
}
