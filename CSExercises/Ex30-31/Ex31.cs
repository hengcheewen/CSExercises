using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            
            int sumoffactors;
            

            for (int i = 1; i <= 1000; i++)
            {
                sumoffactors = 0;
                

                for (int j = 1; j <= i ; j++)
                {
                    if (i !=j)
                    {
                        if (i % j == 0) { sumoffactors = sumoffactors + j; }
                    }  
                }
                if (i == sumoffactors) //perfect number condition.
                { 
                    Console.Write(i); Console.Write("  is a perfect number");
                    Console.WriteLine();
                }
            }  
            string exit = Console.ReadLine();
        }
    }
}
