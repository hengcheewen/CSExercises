using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
      public static string Substitute(string s, char c1, char c2)
        {
            string subnew = " ";

            for (int i = 0; i <= s.Length - 1; i++ )
            {
                if (s.Substring(i, 1) == "c1") 
                {
                    subnew += "c2";
                }
                else { subnew += s.Substring(i, 1); }
            }
                return subnew;
        }
    }
}
