using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly BasedProjectDbContext _context;

        public CategoryRepository(BasedProjectDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
           _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Guid categoryId)
        {
            var category = Find(categoryId);
            if(category != null)
            {
                DeleteCategory(category);
            }
        }

        public Category Find(Guid categoryId)
        {
            
            return _context.Categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public IList<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
