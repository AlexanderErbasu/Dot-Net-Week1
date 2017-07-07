using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4_6july2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var adriana1 = new Adriana { ID = 1, Name = "Adriana" };
            var adriana2 = new Adriana { ID = 1, Name = "Adriana" };
            var adriana3 = new Adriana { ID = 3, Name = "Adriana" };
            var adriana4 = adriana1;

            Console.WriteLine(adriana1.Equals(adriana2));
            Console.WriteLine(adriana1.Equals(adriana3));
            Console.WriteLine(adriana1==adriana2);
            Console.WriteLine(adriana1.Equals(adriana4));
            Console.WriteLine(adriana1 == adriana4);

            Console.ReadLine();
        }
    }
}
