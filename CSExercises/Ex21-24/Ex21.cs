using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer number:   ");
            int x = Convert.ToInt16(Console.ReadLine());

            for (x = 0; x < 88;x++ )
            {
                Console.WriteLine(x);
            }

            if(x==88)
            {
                Console.WriteLine("Lucky you ..........");
            }
            
        }
        
    }
}
