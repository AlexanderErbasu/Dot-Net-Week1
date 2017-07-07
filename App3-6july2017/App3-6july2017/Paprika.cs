using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_6july2017
{
    public class Paprika : IDisposable
    {
        public Paprika()
        {
            Console.WriteLine("Construncting Paprika");
        }
        ~Paprika()
        {
            Console.WriteLine("Destructing Paprika");
        }
        public void Dispose()
        {
            Console.WriteLine("Disposing Paprika");
        }
    }
}
