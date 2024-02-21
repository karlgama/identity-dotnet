namespace identity.controllers;

using AutoMapper;
using identity.Data.Dtos;
using identity.Data.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
    private IMapper _mapper;
    private UserManager<User> _userManager;

    public UserController(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO dto)
    {
        User user = _mapper.Map<User>(dto);
        var res = await _userManager.CreateAsync(user, dto.Password);
        Console.WriteLine(res);
        if (res.Succeeded) return Ok("user created");

        throw new ApplicationException("Failed");
    }
}