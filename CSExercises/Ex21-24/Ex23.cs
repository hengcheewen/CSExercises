using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();


            int secretNumber = (int) rnd.Next(0, 9);
            int guess=0;
            int count = 0;

            if (guess < 10) 
            { 
            while (guess != secretNumber)
            {
               
                Console.Write("Please enter your guess (0-9): ");
                guess = Convert.ToInt32(Console.ReadLine());
                count++;

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations.It took you "+count+" attempts to guess correctly.");
                }
                else
                {
                    Console.WriteLine("It's wrong. Please try again.");
                }
             if(guess>=10)
             {
                 Console.WriteLine("You have key in a number equals to or more than 10");
                }
             if ((count <=2) &&(guess == secretNumber))
             { 
                 Console.WriteLine("You are a Wizard!"); 
             }
             if((count>2)&&(count<=5))
             {
                 Console.WriteLine("You are a good guess.");
             }
             if(count>5)
             {
                 Console.WriteLine("You are lousy!");
             }
            }
            }
        }
    }
}
