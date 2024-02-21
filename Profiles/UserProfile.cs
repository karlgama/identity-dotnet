using AutoMapper;
using identity.Data.Dtos;
using identity.Data.models;

namespace identity.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDTO, User>();
    }
}