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
    private SignInManager<User> _signInManager;

    public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _mapper = mapper;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<IdentityResult> CreateUser(CreateUserDTO dto)
    {
        User user = _mapper.Map<User>(dto);
        var res = await _userManager.CreateAsync(user, dto.Password);

        if (res.Succeeded) return res;

        throw new ApplicationException("Failed");
    }

    public async Task Login(LoginUserDTO dto)
    {
        var res = await _signInManager.PasswordSignInAsync(dto.Username,
        dto.Password, false, false);

        if (!res.Succeeded)
        {
            throw new ApplicationException("Login error");
        }
    }
}
