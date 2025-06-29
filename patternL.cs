using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class L
    {
        public static string l(int n)
        {
            string l = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || i ==n)
                    {
                        l+="* ";

                    }
                    else
                    {
                        l+="  ";
                    }

                }
                l+="\n";

            }
            return l;
        }
    }
}
