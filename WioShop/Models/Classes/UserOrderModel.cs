using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class UserOrderModel
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Tutar { get; set; }
        public EnumOrderState OrderState { get; set; }
        public DateTime OrderDate { get; set; }

    }
}