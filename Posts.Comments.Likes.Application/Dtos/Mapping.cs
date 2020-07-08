using AutoMapper;
using Posts.Comments.Likes.Application.Helpers;
using Posts.Comments.Likes.Infrastructure.Entities;

namespace Posts.Comments.Likes.Application.Dtos
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Like, LikeDto>();

            CreateMap<User, UserDto>();

            CreateMap<UserDto, User>();

            CreateMap<PaginatedList<Like>, PaginatedListDto<LikeDto>>()
                .ForMember(d => d.PageIndex, s => s.MapFrom(s => s.PageIndex))
                .ForMember(d => d.TotalPages, s => s.MapFrom(s => s.TotalPages))
                .ForMember(d => d.HasPreviousPage, s => s.MapFrom(s => s.HasPreviousPage))
                .ForMember(d => d.HasNextPage, s => s.MapFrom(s => s.HasNextPage))
                .ForMember(d => d.Data, s => s.MapFrom(s => s));
        }
    }
}