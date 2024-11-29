using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.UnitTest.RepositoryTests
{
    [TestFixture]
    public class PostRepositoryTests : RepositoryTestBase 
    {
        private PostRepository _postRepository;

        [SetUp]
        public void SetUp()
        {
            _postRepository = new PostRepository(_context);
        }

        [Test]
        public void AddPost_ShouldAddPostSuccessfully()
        {
            // Arrange
            var post = new Post
            {
                Title = "Test Post",
                ShortDescription = "Description",
                PostContent = "Content",
                PostedOn = DateTime.UtcNow,
                CategoryId = Guid.NewGuid()
            };

            // Act
            _postRepository.AddPost(post);
            _context.SaveChanges();

            // Assert
            var addedPost = _context.Posts.FirstOrDefault(p => p.Title == "Test Post");
            Assert.IsNotNull(addedPost);
        }

        [Test]
        public void AddPost_ShouldFail_WhenRequiredFieldsAreMissing()
        {
            // Arrange
            var post = new Post
            {
                ShortDescription = "Description",
                PostContent = "Content",
                PostedOn = DateTime.UtcNow
            }; // Missing Title and CategoryId

            // Act & Assert
            Assert.Throws<DbUpdateException>(() =>
            {
                _postRepository.AddPost(post);
                _context.SaveChanges();
            });
        }

        [Test]
        public void FindPost_ShouldReturnCorrectPost()
        {
            // Arrange
            var post = new Post
            {
                Title = "Findable Post",
                PostedOn = DateTime.UtcNow,
                CategoryId = Guid.NewGuid()
            };
            _context.Posts.Add(post);
            _context.SaveChanges();

            // Act
            var foundPost = _postRepository.FindPost(post.Id);

            // Assert
            Assert.IsNotNull(foundPost);
            Assert.AreEqual("Findable Post", foundPost.Title);
        }

        [Test]
        public void FindPost_ShouldReturnNull_ForNonExistentPost()
        {
            // Act
            var post = _postRepository.FindPost(Guid.NewGuid());

            // Assert
            Assert.IsNull(post);
        }
    }
}
