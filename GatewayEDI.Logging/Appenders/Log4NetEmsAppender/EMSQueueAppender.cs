using System.Net;
using System.Net.Sockets;
using log4net.Appender;
using log4net.Core;
using Messaging.Contracts;
using Messaging.Transport.Ems;

namespace Log4NetEmsAppender
{
    public class EMSQueueAppender : AppenderSkeleton
    {
        public string Uri { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }

        public void WriteCrap(string message)
        {
            var data = new log4net.Core.LoggingEventData();
            data.Message = message;
            data.Level = Level.Error;
            Append(new log4net.Core.LoggingEvent(data));
        }

        protected override void Append(log4net.Core.LoggingEvent loggingEvent)
        {
            var platformInfo = new PlatformInfo
            {
                Host = Uri,
                Path = QueueName,
                Username = UserName,
                Password = Password ?? string.Empty
            };
            var transportLayer = new EmsTransportLayer(platformInfo);
            var logMessage = new Message();
            logMessage.SetBody<string>(loggingEvent.RenderedMessage);
            logMessage.AddHeader("LogLevel", loggingEvent.Level.ToString());
            transportLayer.SendMessage(logMessage);
        }

        private string GetIpAddress()
        {
            var ipAddress = string.Empty;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var address in host.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    ipAddress = address.ToString();
            }
            return ipAddress;
        }
        protected override void Append(log4net.Core.LoggingEvent[] loggingEvents)
        {
            base.Append(loggingEvents);
        }

        protected override bool RequiresLayout
        {
            get
            {
                return true;
            }
        }
    }
}
