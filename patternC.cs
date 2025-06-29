using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class C
    {
        public static string c(int n)
        {
            string c = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1&&j!=1||i==n&&j!=1||j==1&&i!=1&&i!=n)
                    {
                        c+="* ";

                    }
                    else
                    {
                        c+="  ";
                    }

                }
                c+="\n";


            }
            return c;
           
        }
    }
}
