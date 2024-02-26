using AutoMapper;
using identity.Data.Dtos;
using identity.Data.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;

namespace identity.services;

public class UserService
{
    private IMapper _mapper;
    private UserManager<User> _userManager;

    public UserService(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<IdentityResult> CreateUser(CreateUserDTO dto)
    {
        User user = _mapper.Map<User>(dto);
        var res = await _userManager.CreateAsync(user, dto.Password);

        if (res.Succeeded) return res;

        throw new ApplicationException("Failed");
    }
}
