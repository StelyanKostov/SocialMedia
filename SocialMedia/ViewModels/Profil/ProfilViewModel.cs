using Microsoft.AspNetCore.Http;
using SocialMedia.Data;
using SocialMedia.ViewModels.Image;
using SocialMedia.ViewModels.Likes;
using SocialMedia.ViewModels.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.ViewModels.Profil
{
    public class ProfilViewModel
    {
        public ProfilViewModel()
        {
            this.Images = new HashSet<ImageViewModel>();

        }
        public int id { get; set; }

        public string UserName { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public DateTime DateBirthday { get; set; }

        public string Gender { get; set; }

        public string From { get; set; }

        public int Age => DateTime.Now.Subtract(DateBirthday).Days / 365;

        public string Likes { get; set; }

        public string LookingFor { get; set; }

        public string Description { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string EyesColor { get; set; }

        public string HairColor { get; set; }

        public string Status { get; set; }

        public string Alcohol { get; set; }

        public string Cigarettes { get; set; }

        public ICollection<ImageViewModel> Images { get; set; }

        public IEnumerable<IFormFile> ImagesVieModel { get; set; }

        public List<MessagesViewModel> Messages { get; set; }


    }
}
