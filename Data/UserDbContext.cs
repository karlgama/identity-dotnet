using identity.Data.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace identity.Data;

public class UserDbContext : IdentityDbContext<User>
{
    public UserDbContext(DbContextOptions options) : base(options)
    {
    }
}