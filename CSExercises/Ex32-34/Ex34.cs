using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args) // output not righ, settle OO first before come back
        {
            int [,] M = new int [15,5]; //Marks array
            string[] R = new string[15] {"Student1","Student2","Student3","Student4","Student5","Student6","Student7",
                                          "Student8","Student9","Student10","Student11","Student12",
                                          "Subject Average","Subject Std Dev","Overall Class Average Score"};
            
            string[] C = new string[5] { "Subject1", "Subject2", "Subject3", "Subject4", "Total Marks" };
            
            int [] SubjectAverage = new int[4];
            int[] STD = new int[4];
 
            // Taking in the Marks for the Students.

            for (int i = 0; i <= 11; i++) 
            {
                Console.WriteLine(" Please Marks in order of Subject1 to Subject4 for "+ R[i]);

                int Student_Total = 0;

                for (int j = 0; j<=3; j++)
                {
                    Console.Write(" " + C[j]); Console.Write(" : ");
                    M[i, j] = Convert.ToInt16(Console.ReadLine());
                    Student_Total = Student_Total + M[i, j];
                
                }

                M[i, 4] = Student_Total; 
                Console.WriteLine("Total Score  " + M[i, 4]);
            }

            int class_total = 0;

            for (int j =0; j<=3;j++)
            {
                int subject_total = 0;

                for (int i = 0; i<=11;i++)
                {
                    subject_total = subject_total + M[i, j];
                }
 
                SubjectAverage [j] = subject_total/12;
                Console.WriteLine("Sub Ave " + SubjectAverage[j]  );
                class_total = class_total + subject_total;
            }
            int class_average = class_total / 48;

            string exit = Console.ReadLine();

            Console.WriteLine();
            Console.Write("\t\t{0}  {1}  {2}  {3}\t{4}", C[0], C[1], C[2], C[3], C[4]);
            Console.WriteLine("\n");

            for (int i =0; i <=11; i++)
            {
                Console.Write("{0}            {1}        {2}        {3}        {4}       {5}", R[i], M[i, 0], M[i, 1], M[i, 2], M[i, 3],M[i,4]);
                Console.WriteLine("\n");
             }
            Console.WriteLine("\n\n\n");
            Console.Write("{0}     {1}         {2}         {3}         {4}       ", R[12], SubjectAverage[0], SubjectAverage[1],SubjectAverage[2],SubjectAverage[3]);
            Console.WriteLine("\n\n");
            Console.Write("{0}  {1}         ", R[14], class_average);
            string exit1 = Console.ReadLine();
        }
    }
}
