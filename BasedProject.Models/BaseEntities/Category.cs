using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.Models.BaseEntities
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(1024)]
        public string CategoryUrlSlug { get; set; }

        // Navigation property to Post
        public virtual IList<Post> Posts { get; set; } = new List<Post>();
    }
}
