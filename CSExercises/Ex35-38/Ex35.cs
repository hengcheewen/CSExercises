using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string s;
            string r;
            int count = 0;
            string vowel = "aeiou";

            Console.WriteLine("Please enter a phrase ");
            s = Console.ReadLine();
            
            count = 0;
            for (int i = 0 ; i <= s.Length-1; i++ )
            {
                r = s.Substring(i,1);                           //pass individual alphabet in phrase
         
                for (int j = 0; j <= vowel.Length-1;j++)
                {
                    if (r == vowel.Substring(j,1)) { count++; }// count vowels
                }
            }
            
            Console.WriteLine("Total number of vowels: " + count);//number of vowels statement
            string exit = Console.ReadLine();

            for (int j = 0; j <= vowel.Length - 1; j++)
            {
                count = 0;
                r = vowel.Substring(j, 1);          //pass aeiou
                for (int i=0; i <= s.Length-1;i++)
                {
                    if (r == s.Substring(i, 1)) { count++; } //count for vowels in s
                }
                Console.WriteLine("Number of " + r + " : " + count);
            }
            string exit1 = Console.ReadLine();
        }
    }
}
