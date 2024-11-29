using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.UnitTest.RepositoryTests
{
    [TestFixture]
    public class CategoryRepositoryTests : RepositoryTestBase
    {
        private CategoryRepository _categoryRepository;

        [SetUp]
        public void SetUp()
        {
            _categoryRepository = new CategoryRepository(_context);
        }

        [Test]
        public void AddCategory_ShouldAddCategorySuccessfully()
        {
            // Arrange
            var category = new Category
            {
                CategoryName = "Test Category",
                Description = "Test Description"
            };

            // Act
            _categoryRepository.AddCategory(category);
            _context.SaveChanges();

            // Assert
            var addedCategory = _context.Categories.FirstOrDefault(c => c.CategoryName == "Test Category");
            Assert.IsNotNull(addedCategory);
        }

        [Test]
        public void AddCategory_ShouldFail_WhenNameIsMissing()
        {
            // Arrange
            var category = new Category
            {
                Description = "Missing Name"
            };

            // Act & Assert
            Assert.Throws<DbUpdateException>(() =>
            {
                _categoryRepository.AddCategory(category);
                _context.SaveChanges();
            });
        }
    }
}
