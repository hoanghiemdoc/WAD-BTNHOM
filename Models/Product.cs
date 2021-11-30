using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAD_BTNHOM.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int BrandId { get; set; }

        public int CategoryId { get; set; }

        // khoa ngoai
        public virtual Category Category { get; set; }

    }
}