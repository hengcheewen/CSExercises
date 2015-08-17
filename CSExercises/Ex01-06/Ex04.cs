using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double A;
            double B;

            Console.Write("Enter a double precision number= ");
            A = Convert.ToDouble(Console.ReadLine());
            B = Math.Sqrt(A);
            Console.WriteLine("Square root of the precision number= " + B);
            Console.ReadLine();
        }
    }
}
