using AutoMapper;
using SocialMedia.Data;
using SocialMedia.ViewModels.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SocialMedia.Services.Contacts
{
    public class ContactsService : IContactsService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ContactsService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public List<ContactsInputModel> GetAllMsg()
        {
            var data = this.db.ContactsMessages.ToList();
            var viewModel = this.mapper.Map<List<ContactsInputModel>>(data);
            return viewModel.OrderByDescending(x => x.SentOn).ToList();
        }

        public bool SaveContactsForm(ContactsInputModel contactsInputModel)
        {
            try
            {
                var data = mapper.Map<Data.ContactsMessages>(contactsInputModel);

                data.SentOn = DateTime.Now;
                this.db.ContactsMessages.Add(data);
                this.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
