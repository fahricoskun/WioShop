using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Region
    {
        public int Id { get; set; }

        [Description("Bölge Adı")]
        public string RegionName { get; set; }
        public List<Cargo> Cargos { get; set; }
    }
}