using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class F
    {
        public static string f(int n)
        {
            string f = "";
            for (int i = 1; i <= n; i++)
            {
                


                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || i == 1 ||i==(n/2)+1)
                    {
                        f+="* ";

                    }
                    else
                    {
                        f+="  ";
                    }

                }
                f+="\n";

            }
            return f;
           
        }
    }
}
