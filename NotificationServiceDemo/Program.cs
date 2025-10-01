using System;
using System.Collections.Generic;

namespace NotificationServiceDemo
{
    internal class Program
    {
        static void Main()
        {
            var notifications = new List<Notification>
            {
                new EmailNotification("alice@example.com"),
                new SmsNotification("+123456789"),
                new PushNotification("User123")
            };

            foreach (var n in notifications)
            {
                n.Send("Your order has been shipped!");
            }
        }
    }
}