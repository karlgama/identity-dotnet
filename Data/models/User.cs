using Microsoft.AspNetCore.Identity;

namespace identity.Data.models;

public class User : IdentityUser
{
    public DateTime BirthDate { get; set; }

    public User() : base()
    {

    }
}