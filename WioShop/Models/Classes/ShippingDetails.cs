using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
  public class ShippingDetails
    {

        public string UserName { get; set; }


        [Required(ErrorMessage = "Adresinizi Giriniz")]
        public string AdresBasligi { get; set; }


        [Required(ErrorMessage = "Adres Giriniz")]
        public string Adres { get; set; }


        [Required(ErrorMessage = "Şehir Giriniz")]
        public string Sehir { get; set; }


        [Required(ErrorMessage = "Semt Giriniz")]
        public string Semt { get; set; }


        [Required(ErrorMessage = "Mahalle Giriniz")]
        public string Mahalle { get; set; }


        [Required(ErrorMessage = "Posta Kodu Giriniz")]
        public string PostaKodu { get; set; }

    }
}