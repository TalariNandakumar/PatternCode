using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class T
    {
        public static string t(int n)
        {
            string t = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == (n / 2) + 1||i==1)
                    {
                        t += "* ";

                    }
                    else
                    {
                       t+="  ";
                    }

                }
               t+="\n";

            }
           return t;
        }
    }
}
