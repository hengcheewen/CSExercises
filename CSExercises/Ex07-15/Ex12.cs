using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            
            double distance, tfare;
            
            Console.Write("enter distance traveled by ABC taxi =");
            distance = Convert.ToDouble(Console.ReadLine());
            tfare = 2.4 + distance * .4;
            Console.Write("round fare is {0:c}", tfare);
            Console.ReadLine();
        }
    }
}
