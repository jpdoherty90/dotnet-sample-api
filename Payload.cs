using System;

namespace HelloWorldApi
{
    public class Payload
    {
        public DateTime currentTime { get; set; }

        public string hostName { get; set; }

        public string message { get; set; }

        public Payload(DateTime time, string host, string msg) {
            currentTime = time;
            hostName = host;
            message = msg;
        }
    }
}