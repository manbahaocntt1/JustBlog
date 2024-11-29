using BasedProject.Models.BaseEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BasedProject.DataAccess
{
    public class BasedProjectDbContext : IdentityDbContext<User>
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
        public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the many-to-many relationship between Post and Tag
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity(j => j.ToTable("PostTags"));

            // Configure the one-to-many relationship between Post and Comment
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            //seed the dummy data
            SeedData.Seed(modelBuilder);
        }
    }
}
