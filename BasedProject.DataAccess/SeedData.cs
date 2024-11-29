using BasedProject.Models.BaseEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BasedProject.DataAccess
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Define fixed GUIDs for categories
            var techCategoryId = Guid.Parse("bc91bb55-c0f2-4012-a0a7-8b5a5ed626c9");
            var lifestyleCategoryId = Guid.Parse("c1a50d85-b239-4281-9de1-4fb911d525cf");
            var travelCategoryId = Guid.Parse("4bc46f19-70f8-47b9-99c8-045ecdc99da2");

            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = techCategoryId, CategoryName = "Technology", Description = "All about tech", CategoryUrlSlug = "technology" },
                new Category { Id = lifestyleCategoryId, CategoryName = "Lifestyle", Description = "Tips for better living", CategoryUrlSlug = "lifestyle" },
                new Category { Id = travelCategoryId, CategoryName = "Travel", Description = "Explore the world", CategoryUrlSlug = "travel" }
            );

            // Define fixed GUIDs for tags
            var csharpTagId = Guid.Parse("e5f20ab3-bf82-482a-a977-6a5c2bbff803");
            var efCoreTagId = Guid.Parse("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54");
            var aspnetTagId = Guid.Parse("b7ad3e42-815f-421c-b3b8-4f7a7b94622e");

            // Seed data for Tags
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = csharpTagId, TagName = "C#", TagUrlSlug = "csharp",UsageCount = 250 },
                new Tag { Id = efCoreTagId, TagName = "EF Core", TagUrlSlug = "ef-core", UsageCount = 270 },
                new Tag { Id = aspnetTagId, TagName = "ASP.NET", TagUrlSlug = "aspnet", UsageCount = 240 },
                 new Tag { Id = Guid.NewGuid(), TagName = "Technology", TagUrlSlug = "technology", UsageCount = 150 },
        new Tag { Id = Guid.NewGuid(), TagName = "Programming", TagUrlSlug = "programming", UsageCount = 120 },
        new Tag { Id = Guid.NewGuid(), TagName = "C#", TagUrlSlug = "c-sharp", UsageCount = 100 },
        new Tag { Id = Guid.NewGuid(), TagName = "ASP.NET", TagUrlSlug = "asp-net", UsageCount = 80 },
        new Tag { Id = Guid.NewGuid(), TagName = "Web Development", TagUrlSlug = "web-development", UsageCount = 70 }
            );

            // Define fixed GUIDs for posts
            var post1Id = Guid.Parse("95b4fcf6-a59b-4477-b815-10262cfea221");
            var post2Id = Guid.Parse("f517791a-738e-471c-8f2e-ad18e139038e");
            var post3Id = Guid.Parse("e3797fba-c8ba-41c2-ad56-4ac68cfaf495");

            // Seed data for Posts
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = post1Id,
                    Title = "Getting Started with ASP.NET",
                    ShortDescription = "A guide to ASP.NET for beginners",
                    PostContent = "ASP.NET is a powerful framework...",
                    PostUrlSlug = "getting-started-aspnet",
                    Published = true,
                    PostedOn = DateTime.UtcNow,
                    CategoryId = techCategoryId // Correctly assigned CategoryId
                },
                new Post
                {
                    Id = post2Id,
                    Title = "Healthy Living Tips",
                    ShortDescription = "Tips for a healthy lifestyle",
                    PostContent = "Living a healthy life involves...",
                    PostUrlSlug = "healthy-living-tips",
                    Published = true,
                    PostedOn = DateTime.UtcNow,
                    CategoryId = lifestyleCategoryId // Correctly assigned CategoryId
                },
                new Post
                {
                    Id = post3Id,
                    Title = "Top 10 Travel Destinations",
                    ShortDescription = "The best places to visit this year",
                    PostContent = "From beaches to mountains, explore...",
                    PostUrlSlug = "top-travel-destinations",
                    Published = true,
                    PostedOn = DateTime.UtcNow,
                    CategoryId = travelCategoryId // Correctly assigned CategoryId
                }
            );

            // Seed data for PostTags (many-to-many relationship)
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity(j => j.HasData(
                    new { PostsId = post1Id, TagsId = aspnetTagId },
                    new { PostsId = post1Id, TagsId = efCoreTagId },
                    new { PostsId = post2Id, TagsId = csharpTagId },
                    new { PostsId = post3Id, TagsId = csharpTagId },
                    new { PostsId = post3Id, TagsId = aspnetTagId }
                ));
        }
        public static async Task SeedAdminUser(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var adminEmail = "admin@example.com";
            var adminPassword = "Admin@1234";
            var fullName = "HaoMB";

            // Ensure the Admin role exists
            if (!await roleManager.RoleExistsAsync("Admin"))
                await roleManager.CreateAsync(new IdentityRole("Admin"));

            // Create Admin user
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new User { UserName = adminEmail, Email = adminEmail, FullName=fullName };
                await userManager.CreateAsync(adminUser, adminPassword );
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }

    }

}
