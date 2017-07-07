using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_6july17
{

    class MailSorter
    {
        public event MailReceivedEvent MailWithAdressReceived;
        public event MailReceivedEvent MailWithoutAdressReceived;

        public void HandleMailSort(Plic p)
        {
            if (p.Numar != null)
            {
                //Console.WriteLine(String.Format("Good Mail Sorted with numeber {0}", p.Numar));
                MailWithAdressReceived(p);
            }
            else
            {
                //Console.WriteLine("Bad mail sorted: no address");
                MailWithoutAdressReceived(p);
            }
        }

        public void MailReceived(List<Plic> plicProst, List<Plic> plicBun)
        {

        }
    }
}
