using AutoMapper;
using CidadeSemLimites.Communication.Requests.Posts;
using CidadeSemLimites.Communication.Requests.Waypoints;
using CidadeSemLimites.Communication.Responses.Posts;
using CidadeSemLimites.Communication.Responses.Waypoints;
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
            CreateMap<RequestAddWaypointJson, Waypoints>();
        }

        private void EntityToResponse()
        {
            CreateMap<Posts, ResponseAddPostJson>();
            CreateMap<Posts, ResponseGetPostsBaseJson>();
            CreateMap<Waypoints, ResponseAddWaypointJson>();
        }
    }
}
