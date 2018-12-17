using System;
using System.Collections.Generic;
using System.Text;

namespace Richter_Event
{
    class Fax
    {
        public Fax(MailManager mm)
        {
            mm.newMail += FaxMsg;
        }
        private void FaxMsg(object sender,NewMailEventArgs e)
        {
            Console.WriteLine("Faxing mail message:");
            Console.WriteLine(" From={0}, To={1}, Subject={2}",
            e.From, e.To, e.Subject);
        }

        public void Unregister(MailManager mm)
        {
            mm.newMail -= FaxMsg;
        }
    }
}
