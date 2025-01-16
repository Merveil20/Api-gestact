using GestAct.Models;
using Microsoft.EntityFrameworkCore;


namespace GestAct.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
