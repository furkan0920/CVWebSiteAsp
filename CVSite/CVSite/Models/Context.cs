using Microsoft.EntityFrameworkCore;

namespace CVSite.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        
        public DbSet<About> Abouts { get; set; }
        public DbSet<Conferance> Conferancess { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Hobbies> Hobbiees { get; set; }
        public DbSet<Skills> Skillls { get; set; }



    }
}
