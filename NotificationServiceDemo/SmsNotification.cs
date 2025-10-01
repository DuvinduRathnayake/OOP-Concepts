using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo
{
    public class SmsNotification : Notification
    {
        public SmsNotification(string recipient): base(recipient) { }

        public override void Send(string message)
        {
            Console.WriteLine($"📱 SMS to {Recipient}: {message}");
        }
    }
}
