using LifePartnerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LifePartnerApp.Data
{
    public class LifePartnerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Message> Messages { get; set; }

        public LifePartnerContext(DbContextOptions<LifePartnerContext> options) : base(options)
        {
        }
    }
}
