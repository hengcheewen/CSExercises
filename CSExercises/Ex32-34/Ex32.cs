using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] SalesMonth = new int[12];
            int maxsalesmonth = 0;
            int minsalesmonth = 0;
            int avgsales = 0;
            int totsales = 0;
            for (int i=0; i<=11; i++)
            {
                Console.Write("enter sales figure for the month " + i); Console.Write(" =  ");
                SalesMonth[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxsales = SalesMonth[0];
            int minsales = SalesMonth[0];

            for (int i = 0; i <= 11; i++) 
            {
                totsales = totsales + SalesMonth[i]; 
                if (SalesMonth[i] > maxsales) { maxsalesmonth = i; maxsales = SalesMonth[i]; }
                if (SalesMonth[i] < minsales) { minsalesmonth = i; minsales = SalesMonth[i]; }
            }

            avgsales = totsales / 12;
            Console.WriteLine("Maximum Sales = month  " + maxsalesmonth);
            Console.WriteLine("Minimum Sales = month  " + minsalesmonth);
            Console.WriteLine("Average Sales =   " + avgsales);
            Console.WriteLine("max sales in a month =  " + maxsales);
            Console.WriteLine("min sales in a month =  " + minsales);
            string exit = Console.ReadLine();


            
        }
    }
}
