using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2.Head
{
    public abstract class Message
    {
        public Message(string? message, int mobile)
        {
            Mobile = mobile;
            MessageContent = message;
        }

        public Message(string? message, string email)
        {
            Email = email;
            MessageContent = message;
        }

        private int Mobile { get; set; }
        private string Email { get; set; }
        private string MessageContent { get; set; }

        public abstract void Send();
    }
}
