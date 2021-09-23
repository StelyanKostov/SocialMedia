using Microsoft.AspNetCore.Mvc;
using SocialMedia.Services.Contacts;
using SocialMedia.ViewModels.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsService contactsService;

        public ContactsController(IContactsService contactsService)
        {
            this.contactsService = contactsService;
        }


        public IActionResult Index(string responseMsg)
        {

            //if (responseMsg != null)
            //{
            //    return this.View("Index", responseMsg);
            //}
            return this.View();
        }



        public IActionResult ContactForm(ContactsInputModel contactsInputModel)
        {
            var responseMsg = this.contactsService.SaveContactsForm(contactsInputModel);
            this.TempData["Response"] = responseMsg;
            return this.RedirectToAction("Index");
        }
    }
}
