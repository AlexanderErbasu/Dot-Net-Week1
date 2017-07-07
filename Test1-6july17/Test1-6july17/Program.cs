using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_6july17
{
    class Program
    {
        static void Main(string[] args)
        {
            var mailroom = new Mailroom();
            var mailSorter = new MailSorter();

            mailroom.MailReceived += mailSorter.HandleMailSort;
            mailSorter.MailWithoutAdressReceived += MailSorter_MailWithoutAdressReceived;
            mailSorter.MailWithAdressReceived += MailSorter_MailWithAdressReceived;

            mailroom.GoodMailGeneration(80);
            mailroom.BadMailGeneration(20);

            Console.ReadLine();
        }

        private static void MailSorter_MailWithAdressReceived(Plic p)
        {
            Console.WriteLine(String.Format("Mail received with good number {0}", p.Numar));
        }

        private static void MailSorter_MailWithoutAdressReceived(Plic p)
        {
            Console.WriteLine(String.Format("Bad mail received--> only has the address {0}", p.Strada));
        }

    }
}
