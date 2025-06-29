using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class Z
    {
        public static string z(int n)
        {
            string z = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n||i+j==n+1)
                    {
                        z+="* ";

                    }
                    else
                    {
                        z+="  ";
                    }

                }
                z+="\n";

            }
            return z;
        }
    }
}
