using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.models
{
    public class User
    {   
        
        private long id;

        private string username;

        private string password;
        
        public User(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public long Id { get { return id; } }
        public string Username { get { return username;} }
        public string Password { get { return password;} }
      
    }
}
