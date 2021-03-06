using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
        // by alphabet
        
            {

            string[] Name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] Marks = new int[5] { 63, 29, 75, 82, 55 };
            string[] Title = new string[2] { "Names", "Marks" };

            Console.Write("Marks arranged according to student name alphabetical order");
            Console.Write("\n-------------------------------------------------------------\n");
            Console.Write("\t\t{0}\t\t{1}", Title[0], Title[1]);
            Console.Write("\n-------------------------------------------------------------\n");

                for (int i = 0; i <= Name.Length-1; i++) 
                {
                string firstname = Name[i];
                int firstmark = Marks[i];

                    for (int j = i; j <= Name.Length-1; j++) 
                
                    {
                        int check = Name[j].CompareTo(Name[i]);
                
                        if (check == -1) //find smaller as preceding
                    
                     {
                        firstname=Name[j];
                        firstmark=Marks[j];
                        Name[j] = Name[i];
                        Marks[j] = Marks[i];
                        Name[i]=firstname;
                        Marks[i]=firstmark;
                    
                     }
                    }   
                    
                    Console.Write("\t\t{0}\t\t{1}", Name[i], Marks[i]);
                    Console.WriteLine();
                }
           
            

                //by marks
                
                    Console.Write("\n\nMarks arranged according to Rank");
                    Console.Write("\n-------------------------------------------------------\n");
                     Console.Write("\n\t\t{0}\t\t{1}", Title[0], Title[1]);
                     Console.Write("\n------------------------------------------------------\n");
                
                    for (int i = 0; i <= 4; i++)
                    {
                        string firstrank = Name[i];
                        int firstrankmark = Marks[i];

                        for (int j = i; j <= 4; j++)
                     {
                         if (Marks[j] > Marks[i])
                        {
                            firstrank = Name[j];
                            firstrankmark = Marks[j];
                            Name[j] = Name[i];
                            Marks[j] = Marks[i];
                            Name[i] = firstrank; //go back first rank first loop
                            Marks[i] = firstrankmark;

                        }
                     }
                         Console.Write("\t\t{0}\t\t{1}", Name[i], Marks[i]);
                        Console.WriteLine();
                    }
                        string exit = Console.ReadLine();
            }
        }
    }
}