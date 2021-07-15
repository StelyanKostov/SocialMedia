using AutoMapper;

namespace SocialMedia.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Profils, ViewModels.Profil.ProfilViewModel>();
            CreateMap<ViewModels.Profil.ProfilViewModel, Data.Profils>();

            CreateMap<ViewModels.Messages.MessagesViewModel, Data.Messages>();
            CreateMap<Data.Messages, ViewModels.Messages.MessagesViewModel>();

            CreateMap<Data.Image, ViewModels.Image.ImageViewModel>();
            CreateMap<ViewModels.Image.ImageViewModel, Data.Image>();

            CreateMap<ViewModels.Comments.CommentsViewModel, Data.Comments>();
            CreateMap<Data.Comments, ViewModels.Comments.CommentsViewModel>();

            CreateMap<Data.Likes, ViewModels.Likes.LikesViewModel>();
            CreateMap<ViewModels.Likes.LikesViewModel, Data.Likes>();

            CreateMap<ViewModels.Chat.RealTimeMessagesViewModel, Data.RealTimeChat>();
            CreateMap<Data.RealTimeChat, ViewModels.Chat.RealTimeMessagesViewModel>();

        }

    }
}
