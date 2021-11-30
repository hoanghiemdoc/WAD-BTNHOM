using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAD_BTNHOM.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string CategoryImage { get; set; }


        // khoa ngoai
        public virtual ICollection<Product> Products { get; set; }

    }
}