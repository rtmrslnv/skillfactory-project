using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace AwesomeNetwork.Models.Users
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }
    }
}
