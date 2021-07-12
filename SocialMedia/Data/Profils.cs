using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Profils
    {
        public Profils()
        {
            this.Images = new HashSet<Image>();

            this.Messages = new HashSet<Messages>();

            this.RouteChat = new HashSet<RouteChat>();

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

        public bool IsDeleted { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<Messages> Messages { get; set; }

        public ICollection<RouteChat> RouteChat { get; set; }


        
    }
}
