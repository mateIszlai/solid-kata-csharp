using System;

namespace dip
{
    public class EmailSender
    {
        public void send(Email email)
        {
            Console.WriteLine($"To:{email.To}, Subject: {email.Subject}, Message: {email.Message}");
        }
    }
}
