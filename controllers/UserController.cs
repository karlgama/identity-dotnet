namespace identity.controllers;

using AutoMapper;
using identity.Data.Dtos;
using identity.Data.models;
using identity.services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("users")]
public class UserController : ControllerBase
{

    private readonly UserService _userService;


    public UserController(UserService createService)
    {
        _userService = createService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO dto)
    {
        await _userService.CreateUser(dto);
        return Ok("user created");
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginUserDTO dto)
    {
        await _userService.Login(dto);
        return Ok("ok");

    }
}