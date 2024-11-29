using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.UnitTest.RepositoryTests
{
    [TestFixture]
    public class TagRepositoryTests : RepositoryTestBase
    {
        private TagRepository _tagRepository;

        [SetUp]
        public void SetUp()
        {
            _tagRepository = new TagRepository(_context);
        }

        [Test]
        public void AddTag_ShouldAddTagSuccessfully()
        {
            // Arrange
            var tag = new Tag
            {
                TagName = "Test Tag"
            };

            // Act
            _tagRepository.AddTag(tag);
            _context.SaveChanges();

            // Assert
            var addedTag = _context.Tags.FirstOrDefault(t => t.TagName == "Test Tag");
            Assert.IsNotNull(addedTag);
        }

        [Test]
        public void AddTag_ShouldFail_WhenNameIsMissing()
        {
            // Arrange
            var tag = new Tag
            {
                TagUrlSlug = "test-slug"
            };

            // Act & Assert
            Assert.Throws<DbUpdateException>(() =>
            {
                _tagRepository.AddTag(tag);
                _context.SaveChanges();
            });
        }
    }
}
