using Microsoft.EntityFrameworkCore;

namespace NewsClasification.Models
{
    public class Entity : DbContext
    {
            public Entity() : base()
            {

            }
            public Entity(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Category> categories { get; set; }

            public DbSet<News> news { get; set; }
           
            public DbSet<Publisher> publishers { get; set; }
           
            public DbSet<User> users { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=. ; Initial Catalog=NewsClassification ; Integrated Security=True;Encrypt=True ; Trust Server Certificate=True");
                base.OnConfiguring(optionsBuilder);
            }
            // add-migration init
            // update-database

        
    }
}
