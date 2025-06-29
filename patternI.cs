using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class I
    {
       
        public static string i(int n)
        {
            string I = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1||i==n||j==(n/2)+1)
                    {
                        I+="* ";

                    }
                    else
                    {
                        I+="  ";
                    }

                }
               I+="\n";

            }
           return I;
        }
    }
}
