using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAD_BTNHOM.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string OrderCode { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
     
        public int UserId { get; set; }


    }
}