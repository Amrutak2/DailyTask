using DotNetCoreWebApiFrontEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebApiFrontEnd.Data
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base (options){
            }
    public DbSet<UserDetails> UserDetails { get; set; }
    }
}
