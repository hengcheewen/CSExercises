using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {

            int sumofnum;
            int intNum;
            int i, j;

            

            Console.Write("enter a positive integer number=  ");
            intNum = Convert.ToInt16(Console.ReadLine());
            i = intNum;


            sumofnum = 0;
            for (j = 1; j < i; j++)
            {
                if (i % j == 0)  // if the remainder of i divided by j is zero, then j is a factor of i
                {
                   sumofnum = sumofnum + j ; //add j to the list
                } 
            }
                    if (sumofnum == i)                        // test if the sum of the factors equals the number itself (in which case it is a perfect number)
                   {
                       Console.WriteLine(intNum + " is a perfect number");
                   }

                   if (sumofnum != i)
                   {
                       Console.WriteLine(intNum + " is NOT a perfect number");
                   }

               
                
             


            {



            }
        }
    }
}
