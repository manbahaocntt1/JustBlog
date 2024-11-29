using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace FA.JustBlog.UnitTest.RepositoryTests
{
    public abstract class RepositoryTestBase
    {
        protected BasedProjectDbContext _context;

        [SetUp]
        public void BaseSetUp()
        {
            var options = new DbContextOptionsBuilder<BasedProjectDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _context = new BasedProjectDbContext(options);
        }

        [TearDown]
        public void BaseTearDown()
        {
            _context.Dispose();
        }
    }
}
