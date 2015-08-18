using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A =    ");
            int A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter B =    ");
            int B = Convert.ToInt16(Console.ReadLine());

            int HCF, LCM, X, Num1,Num2;
            Num1 = A;  
            Num2 = B;  
          
            while (Num2 != 0)  
         {  
              X = Num2;  
              Num2 = Num1 % Num2;  
              Num1 = X;  
          }  
            
            HCF = Num1;  
            LCM = (A * B) / HCF;  
         
         Console.WriteLine("LCM for {0} and {1} is {2}", A, B, LCM);  
         Console.WriteLine("HCF for {0} and {1} is {2}", A, B, HCF); 


            
        }
    }
}
