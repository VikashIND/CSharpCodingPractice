using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.Encode(new Video());
            Console.Read();
        }
    }
}
