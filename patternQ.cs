using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class Q
    {
        public static string q(int n)
        {
            string q = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 && i != 1 && i != n&i!=n-1||i==1&&j!=1&&j!=n-1&&j!=n||j==n-1&&i!=n-1&&i!=1&&i!=n||i==n-1&&j!=n-1&&j!=1&&j!=n||i==j&&i>=(n/2)+1)
                    {
                        q+="* ";

                    }
                    else
                    {
                        q+="  ";
                    }

                }
               q+="\n" ;

            }
            return q;
        }
    }
}
