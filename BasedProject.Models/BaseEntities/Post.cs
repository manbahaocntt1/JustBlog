using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.Models.BaseEntities
{
    public class Post : BaseEntity
    {
        [Required(ErrorMessage = "Post title is required")]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string ShortDescription { get; set; }

        [StringLength(102400)]
        public string PostContent { get; set; }

        [StringLength(1024)]
        public string PostUrlSlug { get; set; }

        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }

        // New fields
        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int TotalRate { get; set; }
        public decimal Rate => RateCount == 0 ? 0 : (decimal)TotalRate / RateCount;

        // Foreign key to Category
        public Guid CategoryId { get; set; }
        public virtual Category ?Category { get; set; }

        // Navigation property to Tag
        public virtual IList<Tag> Tags { get; set; } = new List<Tag>();
        // Navigation property to Comment
        public virtual IList<Comment> Comments { get; set; } = new List<Comment>();

    }
}
