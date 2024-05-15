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

        private DateTime writeDate;
        public Message(long roomid, long msgid, long userid, string message) 
        {
            this.roomid = roomid;
            this.msgid = msgid;
            this.userid = userid;
            this.message = message;
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
        public string getMessage()
        {
            return message;
        }
        public DateTime getWriteDate()
        {
            return writeDate;
        }
    }
}
