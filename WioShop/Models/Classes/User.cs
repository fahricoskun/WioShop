using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPassword { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Product> Products { get; set; }
    }
}