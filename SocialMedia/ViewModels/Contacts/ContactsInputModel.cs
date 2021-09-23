using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Contacts
{
    public class ContactsInputModel
    {
        public string Email { get; set; }
        public string Number { get; set; }
        public string Messages { get; set; }

        public DateTime SentOn { get; set; }
    }
}
