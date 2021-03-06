using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class ContactsMessages
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string Messages { get; set; }

        public DateTime SentOn { get; set; }
    }
}
