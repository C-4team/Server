using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.services
{
    public class ChatService
    {
        private UserRepository userRepository;
        public ChatService(UserRepository userRepository) 
        {
            this.userRepository = userRepository;
        }
    }
}
