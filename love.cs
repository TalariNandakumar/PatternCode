using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternproject
{

    internal class loves
    {
        public static string love(int n)
        {
            string love= "";
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (i <= (n / 2) + 1 && j == 1 && i != 1 || i <= (n / 2) + 1 && j == n && i != 1 || i == 1 && j != 1 && j != n && j != (n / 2) + 1 || j == (n / 2) + 1 && i == n || i > 1 && i < (n / 2) + 1 && j == (n / 2) + 1 || (n / 2) + 1 < i && i < n && j != 1 && j != n && j != (n / 2) + 1)
            //        {
            //            love += "* ";
            //        }
            //        else
            //        {
            //            love += "  ";
            //        }




            //    }
            for (int i = n / 2; i <= n; i += 2)
            {
                for (int j = 1; j < n - i; j += 2)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            int m = 5;
            for (int i = 1; i <= m; i++)
            {

                for (int k = 1; k < i; k++)
                {
                    Console.Write("  ");


                }
                for (int j = i; j <= m; j++)
                {

                    Console.Write("* ");
                }

                for (int j = i; j < m; j++)
                {

                    Console.Write("* ");
                }
                for (int k = i; k < 1; k++)
                {
                    Console.Write("  ");

                }
                Console.WriteLine();
            }
            love += "\n";
            
                return love;
        }
    }
}
