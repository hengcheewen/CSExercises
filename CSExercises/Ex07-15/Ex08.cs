using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {

            double C;

            

            Console.WriteLine(" Enter a temperature in centigrade scale = ");
            C = Convert.ToDouble(Console.ReadLine());
            double F = (1.8*C) + 32;
            Console.WriteLine("Temperature in Fahrenheit = "+ F );
            



        }
    }
}
