using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Models
{
    public class Product
    {
    
        public int ID { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }


        [Display(Name = "Price")]
        public double? Price { get; set; }


        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
