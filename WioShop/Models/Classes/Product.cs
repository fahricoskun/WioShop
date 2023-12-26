using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }

        [DisplayName("Ürün Resmi")]
        public string ProductImg {  get; set; }
        public int Piece { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}