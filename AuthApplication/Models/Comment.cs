using AuthApplication.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        
        
        [Column(TypeName = "nvarchar(500)")]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }
       
        public int ProductID { get; set; }
        
        public virtual ApplicationUser  User { get; set; }
        
        public virtual Product Product { get; set; }

        public bool? Seen { get; set; } = false;
    }
}
