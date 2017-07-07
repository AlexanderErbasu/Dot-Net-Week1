using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp___7july2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonnaci(10));

            Console.ReadLine();
        }
        static int fibonnaci (int n)
        {
            int n1 = 1, n2 = 1;
            int sum = 0;
            for(int i=0;i<n-1;i++)
            {
                
                int aux2 = n2;

                n2 += n1;
                n1 = aux2;
            }

            return n2;
        }

    
    }
}
