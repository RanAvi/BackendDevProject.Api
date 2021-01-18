using AutoMapper;
using BackendDevProject.Domain;

namespace BackendDevProject.Api.Mapper
{
    public class PostsProfile : Profile
    {
        public PostsProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostViewModel, Post>();
        }

    }
}
