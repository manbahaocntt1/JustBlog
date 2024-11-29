using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public interface ICategoryRepository
    {
        Category Find(Guid categoryId);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void DeleteCategory(Guid categoryId);
        IList<Category> GetAllCategories();
    }
}
