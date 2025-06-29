using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class K
    {
        public static string k(int n)
        {
            string k = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j==(n/2)+1||i+j==n+1&&i<=(n/2)+1||i==j&&i>=(n/2)+1)
                    {
                       k+="* ";

                    }
                    else
                    {
                        k+="  ";
                    }

                }
                k+="\n";

            }
            return k;
        }
    }
}
