using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1_7july17
{
    class Program
    {
        static void Main(string[] args)
        {
            var factura = new Factura { ID = 1 , Name = "Gigi" };

            var list = new List<Factura>();
            list.Add(factura);

            var dict = new Dictionary<int, Factura>();
            dict.Add(factura.ID, factura);

            var retreived = dict[1];

            Console.WriteLine(
                
                String.Format(
                    @"Got ID: {0}, Name={1]",
                    retreived.ID,
                    retreived.Name));
        }
    }

    public class Factura {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
