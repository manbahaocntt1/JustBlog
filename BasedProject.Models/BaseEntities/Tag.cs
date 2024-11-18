using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.Models.BaseEntities
{
    public class Tag: BaseEntity
    {
        [Required(ErrorMessage = "Tag name is required")]
        [StringLength(50)]
        public string TagName { get; set; }

        [StringLength(1024)]
        public string TagUrlSlug { get; set; }

        // Navigation property to Post
        public virtual IList<Post> Posts { get; set; } = new List<Post>();
    }
}
