using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAppConsole_7iul17
{
    public interface IBalanceAccount
    {
        int value { get; }
    }
    public class BalanceAccount : IBalanceAccount
    {
        public int value { get; set; }
    }
    class Program
    {
        public static int Divide(IList<IBalanceAccount> list, int divider)
        {
            try
            {
                int sum = 0;
                foreach (var x in list)
                {
                    sum += x.value;
                }
                return sum / divider;
            }
            catch
            {
                Console.WriteLine("Division not supported");
                return 0;
            }
            
        }

        static void Main(string[] args)
        {
            IList<IBalanceAccount> list1 = new List<IBalanceAccount>(){
                new BalanceAccount { value = 1 },
                new BalanceAccount { value = 2 },
                new BalanceAccount { value = 3 }
            };

            int divider1 = 1;
            int divider0 = 0;
            Console.WriteLine(Divide(list1, divider1));
            Console.WriteLine(Divide(list1, divider0));

            Console.ReadLine();
        }
    }
}
