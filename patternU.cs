using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class U
    {
        public static string u(int n)
        {
            string u = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j ==1&&i!=n||j==n&&i!=n||i==n&&j!=1&&j!=n)
                    {
                       u+="* ";

                    }
                    else
                    {
                       u+="  ";
                    }

                }
                u += "\n";

            }
            return u;
        }
    }
}
