using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo
{
    public class EmailNotification : Notification
    {
        public EmailNotification(string recipient) : base(recipient) { }

        public override void Send(string message)
        {
            Console.WriteLine($"📧 Email to {Recipient}: {message}");
        }
    }
}
