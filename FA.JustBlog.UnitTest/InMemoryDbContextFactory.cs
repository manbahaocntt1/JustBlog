using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.UnitTest
{
    public class InMemoryDbContextFactory
    {
        public static BasedProjectDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<BasedProjectDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            var context = new BasedProjectDbContext(options);

            // Seed initial data if required
            context.Database.EnsureCreated();

            return context;
        }
    }
}
