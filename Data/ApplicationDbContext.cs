using DotNetIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetIdentity.Infra;

public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<User>(options);