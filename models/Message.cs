using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team4.models
{
    public class Message
    {
        private long roomid;

        private long msgid;
        
        private long userid;

        private string message;

        public Message(long roomid, long msgid, long userid, string message) 
        {
            this.roomid = roomid;
            this.msgid = msgid;
            this.userid = userid;
            this.message = message;
        }

        public long getId() 
        {
            return roomid;
        }
        public long getRoomid()
        {
            return roomid;
        }
        public long getMsgid()
        {
            return msgid;
        }
        public long getUserid()
        {
            return userid;
        }
        

    }
}
