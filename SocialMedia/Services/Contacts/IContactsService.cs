using SocialMedia.ViewModels.Contacts;
using System.Collections.Generic;

namespace SocialMedia.Services.Contacts
{
    public interface IContactsService
    {
        public bool SaveContactsForm(ContactsInputModel contactsInputModel);
        public List<ContactsInputModel> GetAllMsg();
    }
}
