using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(double x)
        {
            int Answer = 1;
            if (x == 0) { Answer = 1; }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    Answer = Answer * i;
                }
            }

            return Answer;
        }
    }
}
