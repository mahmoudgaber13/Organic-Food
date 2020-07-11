using AuthApplication.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.ViewModels
{
    public class ProductCreateViewModel
    {
        public string Name { get; set; }

        public IFormFile ImageSrc { get; set; }


        [Display(Name = "Price")]
        public double? Price { get; set; }


        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
