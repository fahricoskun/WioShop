using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Tutar { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }

        public string UserName { get; set; }
        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }


        public virtual List<OrderLine> Orderlines { get; set; }
    }

    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int Miktar {  get; set; }
        public double Price { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}