using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using AuthApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace AuthApplication.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [RegularExpression(@"^(01)[0-9]{9}$")]
        public string Phone { get; set; }

        public string ImagePath { get; set; }

       // public bool? IsActive { get; set; } = true;

        public virtual ICollection<Order>  Orders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
