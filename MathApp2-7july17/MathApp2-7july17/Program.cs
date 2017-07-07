using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp2_7july17
{
    class Program
    {
        static void Main(string[] args)
        {
            string gordon = "Imi place sa ma uit la Gordon Ramsay";
            string nodrog = "";
            for (int i = gordon.Length-1; i >= 0;i--)
            {
                nodrog += gordon[i];
            }

            Console.WriteLine(nodrog);

            Console.ReadLine();
        }
    }
}
