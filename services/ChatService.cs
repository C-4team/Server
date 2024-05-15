using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team4.models;

namespace Team4.services
{
    public class ChatService
    {
        private UserRepository userRepository;
        private TcpListener listener;
        
        private Dictionary<long, Dictionary<TcpClient,NetworkStream>> chatGroups;
        private Queue<UserMessage> messageQueue;

        public ChatService(UserRepository userRepository) 
        {
            this.userRepository = userRepository;
            this.chatGroups = new Dictionary<long, Dictionary<TcpClient, NetworkStream>>();
            messageQueue = new Queue<UserMessage>();
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 13000);

            listener.Start();
        }

        public void acceptRequestDeamon()
        {
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream networkStream = client.GetStream();
                byte[] groupInfo = new byte[sizeof(long)];
                networkStream.Read(groupInfo, 0, sizeof(long));
                string groupInfoString = Encoding.UTF8.GetString(groupInfo);
                long groupId = Group.parseGroupId(groupInfoString);
                if(!chatGroups.ContainsKey(groupId)) 
                { 
                    Dictionary<TcpClient,NetworkStream> newGroup = new Dictionary<TcpClient,NetworkStream>();
                    newGroup.Add(client, networkStream);
                    chatGroups[groupId] = newGroup;
                }
                else
                {
                    chatGroups[groupId].Add(client, networkStream);
                }

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
