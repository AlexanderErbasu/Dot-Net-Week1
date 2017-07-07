using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_6july17
{
    public delegate void MailReceivedEvent(Plic p);

    public class Mailroom
    {
        //event:
        
        public event MailReceivedEvent MailReceived;

        public void HandleMailReceived(Plic p)
        {
            Console.WriteLine("You got a new letter");
        }
        
        
        //generate 100 mails, 80 w/ adress, 20 w/o adress:
        public List<Plic> GoodMailGeneration(int noOfMails)
        {
            
            List<Plic> goodMail = new List<Plic>();
            for(int i = 0; i < noOfMails; i++)
            {
                Plic p = new Plic();
                p.Strada = "Strada Principala";
                p.Numar = i;
                goodMail.Add(p);
                MailReceived(p);
                                
            }
            return goodMail;
        }
        public List<Plic> BadMailGeneration(int noOfMails)
        {
            
            List<Plic> badMail = new List<Plic>();

            for (int i = 0; i < noOfMails; i++)
            {
                Plic p = new Plic();
                p.Strada = "Strada Principala";
                //no numeber
                badMail.Add(p);
                MailReceived(p);
            }
            return badMail;
        }
    }
}
