using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class CargoModel
    {
        public int Id { get; set; }
        public string CargoName { get; set; }
        public string WorkingHours { get; set; }
        public int CargoPrice { get; set; }
        public string CargoImg { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
    }
}