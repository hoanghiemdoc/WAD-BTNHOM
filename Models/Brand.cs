using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAD_BTNHOM.Models
{
    public class Brand
    {

        [Key]
        public int Id { get; set; }

        public string BrandName { get; set; }

        public string Description { get; set; }

        // khoa ngoai
        
    }
}