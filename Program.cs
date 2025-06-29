 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace patternproject
{
    internal class Pattern
    {
        static void Main()
        { 

            Console.Write("  Range : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter Name :");
            string name = Console.ReadLine();

            string[] pattern = new string[name.Length];

            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                switch (c)
                {
                    case 'a': pattern[i] = A.a(n); break;
                    case 'b': pattern[i] = B.b(n); break;
                   // case '*': pattern[i] = loves.love(n); break;
                    case 'c': pattern[i] = C.c(n); break;
                    case 'd': pattern[i] = D.d(n); break;
                    case 'e': pattern[i] = E.e(n); break;
                    case 'f': pattern[i] = F.f(n); break;
                    case 'g': pattern[i] = G.g(n); break;
                    case 'h': pattern[i] = H.h(n); break;
                    case 'i': pattern[i] = I.i(n); break;
                    case 'j': pattern[i] = J.j(n); break;
                    case 'k': pattern[i] = K.k(n); break;
                    case 'l': pattern[i] = L.l(n); break;
                    case 'm': pattern[i] = M.m(n); break;
                    case 'n': pattern[i] = N.n(n); break;
                    case 'o': pattern[i] = O.o(n); break;
                    case 'p': pattern[i] = P.p(n); break;
                    case 'q': pattern[i] = Q.q(n); break;
                    case 'r': pattern[i] = R.r(n); break;
                    case 's': pattern[i] = S.s(n); break;
                    case 't': pattern[i] = T.t(n); break;
                    case 'u': pattern[i] = U.u(n); break;
                    case 'v': pattern[i] = V.v(n); break;
                    case 'w': pattern[i] = W.w(n); break;
                    case 'x': pattern[i] = X.x(n); break;
                    case 'y': pattern[i] = Y.y(n); break;
                    case 'z': pattern[i] = Z.z(n); break;
                    //case 'A': pattern[i] = Love.love(3); break;
                    default: pattern[i] = ""; break;


                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < pattern.Length; i++)
                {

                    string[] rows = pattern[i].Split('\n');

                    Console.Write(rows[row] + "  ");

                }
                Console.WriteLine();
                Thread.Sleep(1000);
            }
            //Console.WriteLine();
            //  loves.love(5);
            //Thread.Sleep(1000);

            Console.Write("------------------------------------------------------------->>>>");
            Console.ReadLine();
        }

       












   
        
          
            




        
    }
}












           


