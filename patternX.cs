using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class X
    {
        public static string x(int n)
        {
            string x = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j || i + j == n + 1)
                    {
                        x += "* ";

                    }
                    else
                    {
                        x += "  ";
                    }

                }
                x += "\n";
            }
            return x;
        }
    }
}
