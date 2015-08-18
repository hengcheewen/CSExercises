using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double A;
            double B;
            //double C;

            Console.Write("Enter a double precision number= ");
            A = Convert.ToDouble(Console.ReadLine());
            B = Math.Sqrt(A);
            //C = Math.Round(B, 3);
            Console.WriteLine("Square root of the precision number= {0:.000}" ,B);
            Console.ReadLine();
        }
    }
}
