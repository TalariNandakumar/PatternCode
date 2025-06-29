using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class O
    {
        public static string o(int n)
        {
            string o = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 && j != n && j != 1||i==n&&j!=1&&j!=n||j==1&&i!=1&&i!=n||j==n&&i!=1&&i!=n)
                    {
                        o+="* ";

                    }
                    else
                    {
                        o+="  ";
                    }

                }
               o+="\n";

            }
            return o;
        }
    }
}
