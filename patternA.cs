using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class A
    {
        public static string a(int n)
        {

            string a = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 && i != 1 || j == n && i != 1 || i == 1 && j != 1 && j != n || i == (n / 2) + 1)
                    {
                        a += "* ";

                    }
                    else
                    {
                        a += "  ";
                    }
                }
                a += "\n";
            }
            return a;

        }
            
    }
}
