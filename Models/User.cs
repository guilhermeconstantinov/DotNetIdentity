using Microsoft.AspNetCore.Identity;

namespace DotNetIdentity.Models;

public class User : IdentityUser
{
    public User()
    {
    }

    public User(string userName) : base(userName)
    {
    }
}
