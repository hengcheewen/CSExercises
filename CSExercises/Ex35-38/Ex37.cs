using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            int i;
            string a;
            string[] b;
            string[] c;
            string titlecase = "";
 
            Console.WriteLine(" Please enter a phrase  ");
            a = Console.ReadLine();
            b = a.Split(' ');
            c = a.Split(' ');

            for(i=0;i<=b.Length-1;i++)

            {
            b[i] = b[i].Substring(0,1).ToUpper(); //each array first char in string ToUpper, array 0 array 1 array 2
            c[i] = b[i].Substring(0,1)+c[i].Substring(1); //get first char of each add b array to from the second char of array c onwards
            titlecase += c[i] + " " ;//array [0][1][2] with space

            }

            Console.WriteLine(titlecase);
            string exit = Console.ReadLine();


            
            
        }
    }
}
