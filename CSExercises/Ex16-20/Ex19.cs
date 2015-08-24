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
            //double tfare=0;
            //Console.WriteLine("enter distance travelled on ABC taxi =");
            //double distance = Convert.ToDouble(Console.ReadLine());
            
            //if (distance <= 0.5) tfare = 2.4;
            //if (distance >0.5) if(distance<=8.5) tfare=2.4+(0.4*(distance/0.1)-0.5);
            //if (distance>9) tfare=2.4+(0.4*((distance-0.5)/0.1))+(0.5*((distance-9)/0.1));
            //Console.WriteLine("therefore the total fare would be {0:c}", tfare);

            double dinitial ;
            double formula ;
            int d100;
            string Total;

            Console.WriteLine("Please enter the distance travelled by ABC taxi");
            dinitial = Convert.ToDouble(Console.ReadLine());

            if (dinitial > 0 && dinitial <= 9)
            {
                d100 = Convert.ToInt32(Math.Ceiling((dinitial - 0.5) / 0.1));
                formula = 2.4 + dinitial * 0.04;
                Total = string.Format("{0:c}", formula);
                Console.WriteLine("The total taxi fare is " + Total);
            }

            else if (dinitial > 9)
            {
                dinitial = Convert.ToInt32(Math.Ceiling((dinitial - 9) / 0.1));
                formula = 2.4 + 85 * 0.04 + dinitial * 0.05;
                Total = string.Format("{0:c}", formula);
                Console.WriteLine(" The total taxi fare is " + Total);

            }

            else if (dinitial < 0) Console.WriteLine(" No such distance!");

            string exit = Console.ReadLine();
            
        
        }

    }
}