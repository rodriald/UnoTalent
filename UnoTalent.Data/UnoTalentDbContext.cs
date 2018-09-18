using Microsoft.EntityFrameworkCore;
using UnoTalent.Data.Entities;

namespace UnoTalent.Data
{
    public class UnoTalentDbContext : DbContext
    {
        public UnoTalentDbContext(DbContextOptions<UnoTalentDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
