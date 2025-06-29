using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class N
    {
        public static string n(int n)
        {
            string N = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == n || i == j)
                    {
                        N += "* ";

                    }
                    else
                    {
                        N += "  ";
                    }
                }
                N += "\n";
        

    
   

            }
            return N;
           
        }
    }
}
