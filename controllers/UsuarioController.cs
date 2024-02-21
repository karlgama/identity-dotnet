namespace identity.controllers;

using identity.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserDTO dto)
    {
        throw new NotImplementedException();
    }
}