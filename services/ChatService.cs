using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
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
        
        private Dictionary<long,Dictionary<User, Dictionary<TcpClient,NetworkStream>>> chatGroups;
        private Queue<UserMessage> messageQueue;

        public ChatService(UserRepository userRepository) 
        {
            this.userRepository = userRepository;
            this.chatGroups = new Dictionary<long, Dictionary<User, Dictionary<TcpClient, NetworkStream>>>();
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

                
                byte[] userInfo = new byte[sizeof(long)];
                
                networkStream.Read(userInfo, 0, sizeof(long));
                
                string userInfoString = Encoding.UTF8.GetString(userInfo);
                
                User user = User.parseUser(userInfoString);
                
                networkStream.Read(groupInfo, 0, sizeof(long));
                
               
                string groupInfoString = Encoding.UTF8.GetString(groupInfo);
                
                long groupId = Group.parseGroupId(groupInfoString);

                if(!chatGroups.ContainsKey(groupId)) 
                {
                    Dictionary < User, Dictionary < TcpClient, NetworkStream >> newGroup = new Dictionary<User, Dictionary<TcpClient, NetworkStream>>();
                    Dictionary<TcpClient, NetworkStream> TCPInfo = new Dictionary<TcpClient, NetworkStream>();
                    TCPInfo.Add(client, networkStream);
                    newGroup.Add(user,TCPInfo);
                    
                    chatGroups[groupId] = newGroup;
                }
                else { 
                    Dictionary<TcpClient, NetworkStream> TCPInfo = new Dictionary<TcpClient, NetworkStream>();
                    TCPInfo.Add(client, networkStream);
                    chatGroups[groupId].Add(user, TCPInfo);
                }

            }
        }
        public void TCPReadDeamon()
        {
          
            while(true)
            {
                foreach(KeyValuePair<long, Dictionary<User, Dictionary<TcpClient, NetworkStream>>> group in chatGroups)
                {

                }
            }
        }
        public void TCPWriteDeamon()
        {

        }
        public void messageQueueDeamon()
        {

        }


    }
}
