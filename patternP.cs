using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class P
    {
        public static string p(int n)
        {
            string p = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 ||i==1&&j!=n||i==(n/2)+1&&j!=n|| j == n && i > 1 && i <= (n / 2) + 1 && i != 1&&i!=(n/2)+1)
                    {
                        p+="* ";

                    }
                    else
                    {
                       p+="  ";
                    }

                }
                p+="\n";

            }
            return p;
        }
    }
}
