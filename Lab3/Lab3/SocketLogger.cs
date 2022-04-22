using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Lab3
{
    public class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;
        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }

        ~SocketLogger()
        {
            this.Dispose(false);
        }

        public void Dispose(bool disposing)
        {
            if(disposing)
            {
                this.clientSocket.Dispose();
            }

        }

        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        public void Log(params string[] messages)
        {
            DateTime currentLog = DateTime.Now;

            foreach (var message in messages)
            {

                string requestText = currentLog + message + " ";
                byte[] requestByte = Encoding.UTF8.GetBytes(requestText);


                clientSocket.Send(requestByte);
            }
        }
    }
}
