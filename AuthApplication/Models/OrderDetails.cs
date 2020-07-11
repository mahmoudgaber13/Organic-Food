using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> OrderId { get; set; }
        public virtual Order Order { get; set; }
        [ForeignKey("Product")]
        public int? ProductID { get; set; }
        public virtual ICollection< Product> Products { get; set; }
    }
}
