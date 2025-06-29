using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class M
    {
        public static string m(int n)
        {
            string m = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 ||j==n||i==j&&i<=(n/2)+1||i+j==n+1&&i<=(n/2)+1)
                    {
                        m+="* ";

                    }
                    else
                    {
                       m+="  ";
                    }

                }
                m += "\n";

            }
           return m;
        }
    }
}
