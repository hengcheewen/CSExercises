using System;
using ISS.RV.LIB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Double income, totalincome, housing, transport;

            Console.Write("Enter employee income = $");
            income = Convert.ToDouble(Console.ReadLine());
            housing = income * .1;
            transport = income * .03;
            totalincome = (income + housing + transport);
            Console.WriteLine("Total income of the employee = $" + totalincome);

        }
    }
}
