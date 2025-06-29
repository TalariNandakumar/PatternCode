using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace patternproject
{
    internal class G
    {
        public static string g(int n)
        {
            string g = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1&&j!=1||i==n&&j!=1||j==1&&i!=1&&i!=n||j==n&&i>=(n/2)+1||i==(n/2)+1&&j>=(n/2)+1)
                    {
                        g+="* ";

                    }
                    else
                    {
                        g+="  ";
                    }

                }
                g+="\n";

            }
            return g;
        }
    }
}
