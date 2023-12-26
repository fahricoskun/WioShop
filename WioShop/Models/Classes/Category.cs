using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        //Data Annotations
        [DisplayName("Kategori Adı")]
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}