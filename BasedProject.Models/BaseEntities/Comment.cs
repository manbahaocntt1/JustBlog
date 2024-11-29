using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.Models.BaseEntities
{
    public class Comment: BaseEntity
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }

        [StringLength(255)]
        public string CommentHeader { get; set; }

        [StringLength(1024)]
        public string CommentText { get; set; }

        public DateTime CommentTime { get; set; }
    }
}
