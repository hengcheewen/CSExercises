using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double tfare=0;
            Console.WriteLine("enter distance travelled on ABC taxi =");
            double distance = Convert.ToDouble(Console.ReadLine());
            
            if (distance <= 0.5) tfare = 2.4;
            if (distance >0.5) if(distance<=8.5) tfare=2.4+(0.4*(distance/0.1)-0.5);
            if (distance>9) tfare=2.4+(0.4*((distance-0.5)/0.1))+(0.5*((distance-9)/0.1));
            Console.WriteLine("therefore the total fare would be {0:c}", tfare);
        }
    }
}