using System.ComponentModel.DataAnnotations;

namespace identity.Data.Dtos;

public class LoginUserDTO
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
