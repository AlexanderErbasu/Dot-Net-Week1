using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_6july2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var paprika = new Paprika();
            try
            {
                using (paprika)
                {
                    throw new Exception("ceva");
                }
            }
            catch
            {

            }
            paprika = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadLine();
        }
    }
}
