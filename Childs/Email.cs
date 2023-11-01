using HW5_2.Head;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_2.Childs
{
    internal class Email : Message
    {

        public Email(string? message, string email) : base(message, email)
        {
            EmailAddress = email;
            MessageContent = message;
        }

        private string EmailAddress { get; set; }
        private string MessageContent { get; set; }

        public override void Send()
        {
            Console.WriteLine($"{EmailAddress}_{MessageContent}");
        }
    }
}
