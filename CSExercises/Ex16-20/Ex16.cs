using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name;
            name = Console.ReadLine();
            Console.Write("What is your gender? Type M or F:      ");
            char gender;
            gender = Convert.ToChar(Console.ReadLine());
            if(gender=='M')
            { Console.WriteLine("Good morning Mr." + name); }
            if(gender=='F')
            { Console.WriteLine("Good morning Ms" + name); }
            else { Console.WriteLine("Thank you for using this program."); }
            

        }
    }
}