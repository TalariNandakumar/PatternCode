using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class J
    {
        public static string  j(int n)
        {
            string J = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || j == (n / 2) + 1 || j == 1 && i >= (n / 2) + 1 && i != n||i==n&&j<=(n/2)+1&&j!=1)
                    {
                        J+="* ";

                    }
                    else
                    {
                        J+="  ";
                    }

                }
               J+="\n";

            }
            return J;
        }
    }
}
