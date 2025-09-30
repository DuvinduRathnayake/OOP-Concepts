using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo
{
    public class Notification
    {
        public string Recipient { get; set; }

        public Notification(string recipient)
        {
            Recipient = recipient;
        }

        public virtual void Send(String message)
        {
            Console.WriteLine($"Sending generic notification to {Recipient}: {message}");
        }
    }
}
