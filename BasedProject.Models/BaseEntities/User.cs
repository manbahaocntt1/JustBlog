using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.Models.BaseEntities
{
    public class User: IdentityUser
    {
        public string FullName { get; set; } // Example custom property
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
