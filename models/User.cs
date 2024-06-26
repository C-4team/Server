﻿using System;
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
        
        public User(long id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }

        public long Id { 
            get { return id; }
            set { id = value; }
        }
        public string Username {
            get { return username;}
            set { username = value; }
        }
        public string Password { 
            get { return password;}
            set { password = value; }
        }
      
        // 여기 부분 수정
        public override string ToString()
        {
            return $"{id},{username},{password}";
        }

        public static User parseUser(string bytes)
        {
            string[] userInfo = bytes.Split(',');
            return new User(long.Parse(userInfo[0]), userInfo[1], userInfo[2]);
        }
    }
}
