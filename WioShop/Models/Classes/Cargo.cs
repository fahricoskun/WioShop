using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Cargo
    {
        public int Id { get; set; }

        [DisplayName("Kargo Adı")]
        public string CargoName { get; set; }

        [DisplayName("Çalışma Saatleri")]
        public string WorkingHours { get; set; }

        [DisplayName("Kargo Başı Ücret")]
        public int CargoPrice { get; set; }
        [DisplayName("Şirket Logosu")]
        public string CargoImg { get; set; }
        public bool IsApproved { get; set; }

        [DisplayName("Bölge Id")]
        public int RegionId { get; set; }
        [DisplayName("Bölge Adı")]
        public string RegionName { get; set; }
        public Region Region { get; set; }
    }
}