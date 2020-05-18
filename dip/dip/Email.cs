using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dip
{
    public class Email
    {
        public string To { get; private set; }
        public string Subject { get; private set; }
        public string Message { get; private set; }

        Email(string to, string subject, string message)
        {
            To = to;
            Subject = subject;
            Message = message;
        }
    }
}
