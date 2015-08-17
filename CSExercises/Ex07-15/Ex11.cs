using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("ENTER DISTANCE TRAVELED IN AN ABC TAXI IN KM = ");
            double Distance = Convert.ToDouble(Console.ReadLine());
            double Tfare = (0.4*Distance) + 2.4;
            Console.Write("The total fare would be = SGD " + Tfare);
            Console.ReadLine();

        }
    }
}
