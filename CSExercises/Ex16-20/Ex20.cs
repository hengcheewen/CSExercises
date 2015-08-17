using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter quantity for TV");
            int TVQTY = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter quantity for DVD");
            int DVDQTY = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter quantity for MP3");
            int MP3QTY = Convert.ToInt16(Console.ReadLine());

            double TVPC = 900;
            double DVDPC = 500;
            double MP3PC = 700;

            double TPrice = (TVQTY * TVPC + DVDQTY * DVDPC)+( MP3QTY * MP3PC);
            if (TPrice > 5000) TPrice = 0.9 * (TPrice - (MP3QTY * MP3PC)) + (MP3QTY * MP3PC);
            if (TPrice > 10000) TPrice = 0.85 * (TPrice - (MP3QTY * MP3PC)) + (MP3QTY * MP3PC);
            Console.WriteLine("Total Price for this order is {0:c}", TPrice);
        }
    }
}