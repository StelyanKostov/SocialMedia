using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.AutoMapper
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
            CreateMap<Data.Profils, ViewModels.Profil.ProfilViewModel>();
            CreateMap<ViewModels.Profil.ProfilViewModel, Data.Profils>();

        }

    }
}
