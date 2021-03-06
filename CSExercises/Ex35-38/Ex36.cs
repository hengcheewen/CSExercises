using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string s;
            string phrase;
            string forward ="";
            string reverse = "";

            Console.WriteLine(" Please enter your phrase");
            s = Console.ReadLine();
            phrase = s.ToLower(); //ignore uppercases
            
            for (int i = 0; i <= phrase.Length -1; i++) //from front
            {
                if (phrase[i]!= ' ' && phrase[i]  != '.' && phrase[i]!='!') //with these not considered palindrome
                {
                    forward += phrase[i]; //pass alphabets forward
                }
            }

            for (int i = phrase.Length - 1; i >= 0; i--) //from back
            {
                if (phrase[i] != ' ' && phrase[i] != '.' && phrase[i] != '!')
                {
                    reverse += phrase[i]; //pass alphabets backwards
                }
            }

            if (forward == reverse) 
            { Console.WriteLine(" Palindrome");}
            else 
            { Console.WriteLine(" NOT Palindrome"); }

            string exit = Console.ReadLine();

        }
    }
}


/*string reversedString = "";
for (int i = inputString.Length - 1; i >= 0; i--)
{
     reversedString += inputString[i];
}

To reverse a string in C# use a for-loop that transverses the string from right to left, copying each character over to a new string, writing the characters from left to right.

Once the string is reversed, the strings are easy compared:
return inputString == reversedString;*/
