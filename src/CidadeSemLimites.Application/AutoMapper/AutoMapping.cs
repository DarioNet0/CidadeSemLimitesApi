using AutoMapper;
using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Domain.Entities;

namespace CidadeSemLimites.Application.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToEntity();
            EntityToResponse();
        }

        private void RequestToEntity()
        {
            CreateMap<RequestAddPostJson, Posts>();
        }

        private void EntityToResponse()
        {
            CreateMap<Posts, ResponseAddPostJson>();
            CreateMap<Posts, ResponseGetPostsBaseJson>();
        }
    }
}
