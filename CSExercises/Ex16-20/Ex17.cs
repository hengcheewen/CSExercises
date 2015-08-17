using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:   ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your gender M or F:   ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter your age:    ");
            int age = Convert.ToInt16(Console.ReadLine());
            if (gender == 'M')
                if (age >= 40)
                    Console.WriteLine("Good morning Uncle  " +name);
            if (gender == 'F')
                if (age >= 40)
                    Console.WriteLine("Good morning Aunty " + name);
            if (gender == 'M')
                if (age < 40)
                    Console.WriteLine("Good morning Mr.  " + name);
            if (gender == 'F')
                if (age < 40)
                    Console.WriteLine("Good morning Ms " + name);
            Console.WriteLine("Thank you for using this program.");
               




        }
    }
}