using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        
        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage = "Geçersiz E-mail Adresi!")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
    }
}