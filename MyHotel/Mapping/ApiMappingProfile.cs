using AutoMapper;
using MyHotel.Api.models;

namespace MyHotel.Api.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<CustomerPostModel, Customer>();
            CreateMap<RoomPostModel, Room>();
            CreateMap<InvitePostModel, Invite>();
        }
    }
}
