using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class H
    {
        public static string h(int n)
        {
            string h = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1||i==(n/2)+1||j==n)
                    {
                        h+="* ";

                    }
                    else
                    {
                        h+="  ";
                    }

                }
                h+="\n";

            }
           return h;
        }
    }
}
