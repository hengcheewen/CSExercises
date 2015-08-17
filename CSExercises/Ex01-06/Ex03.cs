using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double A;
            double B;

            Console.Write("Enter adouble precision number= ");
            A = Convert.ToDouble(Console.ReadLine());
            B = (A)*(A);
            Console.WriteLine("Square of the precision number= " + B);
            Console.ReadLine();

        }
    }
}
