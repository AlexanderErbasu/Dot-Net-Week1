using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5_6july2017
{
    class Program
    {
        //delegate int Add(int x1, int x2);
        //public static int Maria(int x1, int x2)
        //{
        //    return x1 + x2;
        //}
        //public int Ion(int x1, int x2)
        //{
        //    return x1 + x2;
        //}
        static void Main(string[] args)
        {
            //    Console.WriteLine(Maria(1, 2));

            //    Add myReference = Maria;
            //    Console.WriteLine(myReference(1, 2));

            //    var p = new Program();
            //    Add myReference2 = p.Ion;


            //    Console.ReadLine();

            var factura = new Factura();
            factura.FacturaChanged += Factura_FacturaChanged;

            factura.Valoare = 2;
            factura.Valoare = 3;
            factura.Valoare = 4;

            ShowValoare(factura);

            ShowSold(factura);

            factura.Sold = 100;
            ShowSold(factura);

            factura.Sold = null;
            ShowSold(factura);


            Console.ReadLine();
        }

        private static void Factura_FacturaChanged(object sender, Factura e)
        {
            ShowValoare(e);
        }
        private static void Factura_FacturaChanged2(object sender, Factura e)
        {
            Console.WriteLine("I have been called");
        }
        private static void ShowValoare(Factura fact)
        {
            Console.WriteLine(String.Format("Factura are valoarea = {0}", fact.Valoare));
        }
        public static void ShowSold(Factura f)
        {
            if (f.Sold.HasValue)
            {
                Console.WriteLine(String.Format("Factura are sold-ul = {0}", f.Sold.Value));
            }
            else {
                Console.WriteLine("Factura nu are sold");
            }
        }
    }
}
