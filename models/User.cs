using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.models
{
    // UserModel로 Spring Model로 생각하면 됨.
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
