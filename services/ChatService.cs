using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team4.services
{
    public class ChatService
    {
        private UserRepository userRepository;
        private TcpListener listener;

        private Dictionary<long, List<TcpClient>> chatGroups;
        private Queue<Message> messageQueue;

        public ChatService(UserRepository userRepository) 
        {
            this.userRepository = userRepository;
            this.chatGroups = new Dictionary<long, List<TcpClient>>();
            messageQueue = new Queue<Message>();
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);

            listener.Start();
        }

        public void acceptRequestDeamon()
        {
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

              
            }
        }
        public void TCPDeamon()
        {

        }
        public void messageQueueDeamon()
        {

        }


    }
}
