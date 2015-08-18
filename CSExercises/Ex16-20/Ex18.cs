
using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(" Stident Mark=    ");

            int marks=Convert.ToInt16(Console.ReadLine());
            char lettergrade = ' ';
            string error = "**Error**";

            if ((marks >= 80) && (marks <= 100))
                    lettergrade= 'A' ;
            else if ((marks >= 60) && (marks <= 79))
                    lettergrade= 'B';
            else if ((marks >= 40) && (marks <= 59))
                     lettergrade = 'C';
            else if ((marks >= 0) && (marks <= 40))
                     lettergrade = 'F';

            if (lettergrade == ' ')
                Console.WriteLine(error);
            else
                Console.WriteLine(" You scored {0} marks which is a {1} grade.", marks, lettergrade);
           

        }
    }
}