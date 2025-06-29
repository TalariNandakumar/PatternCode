using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class E
    {
        public static string e(int n)
        {
            string e = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 ||i==1||i==n||i==(n/2)+1)
                    {
                        e+="* ";

                    }
                    else
                    {
                        e += "  ";



                    }

                }
                e += "\n";


                

            }
            return e;
            
        }
    }
}
