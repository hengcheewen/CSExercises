using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int A; 
            double B;

            Console.Write("Enter an integer= ");
            A = ISS.RV.LIB.ISSConsole.ReadInt();
            B = (A)*(A);
            Console.WriteLine("Square of integer= " + B);
            Console.ReadLine();






        }
    }
}
