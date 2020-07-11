using AuthApplication.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Models
{
    public class Order
    {
        public Order()
        {
           
        }
        public int ID { get; set; }
        public int ? Quantity { get; set; }
        public string ? Address { get; set; }
        public string ? Email { get; set; }

        public DateTime? Date { get; set; }
        public string? Status { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
