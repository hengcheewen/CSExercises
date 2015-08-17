using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int A;
            double B;

            Console.Write("Enter an integer = ");
            A = Convert.ToInt32(Console.ReadLine()); //not possible ToInt64
            B = Math.Sqrt(A);
            Console.WriteLine("Square root of integer= " + B);
            Console.ReadLine();
        }
    }
}
