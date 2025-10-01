using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo
{
    public class PushNotification : Notification
    {
        public PushNotification(string recipient) : base(recipient) { }

        public override void Send(string message)
        {
            Console.WriteLine($"🔔 Push notification for {Recipient}: {message}");
        }
    }
}
