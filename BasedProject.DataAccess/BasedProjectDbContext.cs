using BasedProject.Models.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace BasedProject.DataAccess
{
    public class BasedProjectDbContext : DbContext
    {
        public BasedProjectDbContext()
        {
            
        }

        public BasedProjectDbContext(DbContextOptions<BasedProjectDbContext> options) : base(options)
        {
            
        }

        //set DbSet<Entity>
       
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the many-to-many relationship between Post and Tag
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity(j => j.ToTable("PostTags"));

            //seed the dummy data
            SeedData.Seed(modelBuilder);
        }
    }
}
