using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            //double X1, X2, Y1, Y2, D;
            Console.WriteLine("Enter the coordinates of two points in the sequence of X1, Y1, X2, Y2");
            Console.WriteLine("Compute the distance between two points using the formula of: ");
            Console.WriteLine(" (X2-X1)^2 + (Y2-Y1)^2");
            

            Console.Write("ENTER X2 = ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER X1 = ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER Y2 = ");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ENTER Y1 = ");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            double D = Math.Sqrt((X2 - X1)*(X2 - X1))+((Y2 - Y1)*(Y2-Y1));
            Console.WriteLine("therefore the distance between two points =" + D);
            
            Console.ReadLine();



        }
    }
}
