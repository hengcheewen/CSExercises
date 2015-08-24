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
            //Console.WriteLine("enter quantity for TV");
            //int TVQTY = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("enter quantity for DVD");
            //int DVDQTY = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("enter quantity for MP3");
            //int MP3QTY = Convert.ToInt16(Console.ReadLine());

            //double TVPC = 900;
            //double DVDPC = 500;
            //double MP3PC = 700;

            //double TPrice = (TVQTY * TVPC + DVDQTY * DVDPC) + (MP3QTY * MP3PC);
            //if (TPrice > 5000) TPrice = 0.9 * (TPrice - (MP3QTY * MP3PC)) + (MP3QTY * MP3PC);
            //if (TPrice > 10000) TPrice = 0.85 * (TPrice - (MP3QTY * MP3PC)) + (MP3QTY * MP3PC);
            //Console.WriteLine("Total Price for this order is {0:c}", TPrice);
            //string exit = Console.ReadLine();

            int tvqty;
            int dvdqty;
            int mp3qty;
            
            double tvcost;
            double dvdcost;
            double mp3cost;
            double dtvcost;
            double ddvdcost;
            double dmp3cost;

            double TotalPrice;

            Console.Write("Enter quantity for TV= ");
            tvqty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD= ");
            dvdqty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3= ");
            mp3qty = Convert.ToInt32(Console.ReadLine());

            mp3cost = dmp3cost = mp3qty * 700;      //setting without discount conditions
            tvcost = dtvcost = tvqty * 900;
            dvdcost = ddvdcost = dvdqty * 500;

            if (tvcost > 5000 && tvcost <= 10000) { dtvcost = tvcost * 0.9; }  // setting the conditions
            if (tvcost > 10000) { dtvcost = tvcost * 0.85; }
            if (dvdcost > 5000 && dvdcost <= 10000) { ddvdcost = dvdcost * 0.9; }
            if (dvdcost > 10000) { ddvdcost = dvdcost * 0.85; }

            TotalPrice = Math.Round((dmp3cost + dtvcost + ddvdcost), 2);

            Console.Write("Total price for this order is $ ");
            Console.Write(TotalPrice);
            string exit = Console.ReadLine();                   
        }
    }
}