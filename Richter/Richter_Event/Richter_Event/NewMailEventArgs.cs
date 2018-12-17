using System;
using System.Collections.Generic;
using System.Text;

namespace Richter_Event
{
    class NewMailEventArgs:EventArgs
    {
        private readonly string m_from, m_to, m_subject;
        public NewMailEventArgs(string from,string to,string subject)
        {
            m_from = from;
            m_to = to;
            m_subject = subject;
        }

        public string From => m_from;

        public string To => m_to;

        public string Subject => m_subject;
    }
}
