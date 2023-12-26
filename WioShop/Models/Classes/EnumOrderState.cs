using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Bekliyor,
        [Display(Name = "Sipariş Tamamlandı")]
        Tamamlandı
    }
}