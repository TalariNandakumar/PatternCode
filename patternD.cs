using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class D
    {
        public static string d(int n)
        {
            string d = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1&&j!=n||i==n&&j!=n||j==1||j==n&&i!=1&&i!=n)
                    {
                        d+="* ";

                    }
                    else
                    {
                        d += "  ";
                        
                    }

                }
                d += "\n";

            }
           return d;
          
        }
    }
}
