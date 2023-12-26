using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImg { get; set; }
        public int Piece { get; set; }

        public int CategoryId { get; set; }
    }
}