using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WAD_BTNHOM.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public int Phone { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string Date { get; set; }
    }
}