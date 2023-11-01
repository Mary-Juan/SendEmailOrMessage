using HW5_2.Head;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2.Childs
{
    internal class Sms : Message
    {
        public Sms(string? message, int mobile) : base(message,mobile)
        {
            Mobile = mobile;
            MessageContent = message;
        }

        private int Mobile { get; set; }
        private string MessageContent { get; set; }

        public override void Send()
        {
            Console.WriteLine($"{Mobile}_{MessageContent}");
        }
    }
}
