using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{
    internal class B
    {
        public static string b(int n)
        {
            string b = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=n; j++)
                {
                  if (i==1&&j!=n||i==n&&j!=n||j==1||i==(n/2)+1&&j!=n||j==n&&i!=1&&i!=n&&i!=(n/2)+1)
                    {
                        b+="* ";

                    }
                    else
                    {
                        b+="  ";
                    }

                }
                b+="\n";


            }
            return b;
           
            
        }
            

    }
}
