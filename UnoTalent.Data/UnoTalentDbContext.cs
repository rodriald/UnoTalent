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
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Question> Questions{ get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<ApplicationQuestion> ApplicationQuestions { get; set; }
    }
}
