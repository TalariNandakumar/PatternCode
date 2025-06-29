using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class V
    {
        public static string v(int n)
        {
            string v = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j==1&&i>=1&&i<=(n/2)+1|| j == n && i >=1 && i <=(n / 2) + 1  ||i==n&&j==(n/2)+1||i<n&&i>(n/2)+1&&j!=(n/2)+1&&j!=1&&j!=n)                                                              
                    {
                       v+="* ";

                    }
                    else
                    {
                        v+="  ";
                    }

                }
                v+="\n";

            }
           return v;
        }
    }
}
