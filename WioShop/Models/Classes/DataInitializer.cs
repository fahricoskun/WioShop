using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web;
using WioShop.Identity;

namespace WioShop.Models.Classes
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { CategoryName="Marvel"},
                new Category() { CategoryName="Architecture"},
                new Category() { CategoryName="Creator Expert"},
                new Category() { CategoryName="Harry Potter"},
                new Category() { CategoryName="Star Wars"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() 
                { 
                    ProductName="Hulkbuster", 
                    ProductDescription="Iron Man'in güçlü ve mega zırhı Hulkbuster!", 
                    ProductPrice=750, 
                    ProductImg = "Hulkbuster.jpg", 
                    Piece=4049, 
                    IsApproved=true,
                    CategoryId = 1
                },
                new Product() 
                { 
                    ProductName="Thor'un Çekici", 
                    ProductDescription = "Marvel Studios Sonsuzluk Destanı’ndan destansı boyutlar, etkileyici detaylar ve simgeleşmiş parçalarla tasarlanan Thor'un efsanevi çekici.", 
                    ProductPrice=1000, 
                    ProductImg = "Thor'un Çekici.jpg", 
                    Piece=381, 
                    IsApproved=true, 
                    CategoryId = 1
                },
                new Product() 
                { 
                    ProductName="Iron Man Figürü", 
                    ProductDescription = "Marvel hayranları, bu inşa edilebilen, tam eklemli Iron Man’i gerçeği gibi hareket ettirebilir ve poz verdirebilir.", 
                    ProductPrice=800, 
                    ProductImg = "Iron Man.jpg", 
                    Piece=979, 
                    IsApproved=true,
                    IsHome=true,
                    CategoryId = 1
                },
                new Product() 
                { 
                    ProductName="Sonsuzluk Eldiveni", 
                    ProductDescription = "Marvel Avengers'ın yetişkin hayranları, bu göz alıcı yap-sergile LEGO® Marvel Sonsuzluk Eldivenini çok beğenecek.", 
                    ProductPrice=900, 
                    ProductImg = "Sonsuzluk Eldiveni.jpg", 
                    Piece=590, 
                    IsApproved=true,
                    IsHome=true,
                    CategoryId = 1
                },

                new Product() 
                { 
                    ProductName="Himeji Kalesi", 
                    ProductDescription="Bu yapım ve sergileme setiyle Japonya’nın en büyük kalesinin dayanıklılığını ve görkemli güzelliğini kutlayın.", 
                    ProductPrice=550, ProductImg = "Himeji Kalesi.jpg", 
                    Piece=2125, 
                    IsApproved=true,
                    CategoryId = 2
                },
                new Product() 
                { 
                    ProductName="Keops Piramidi", 
                    ProductDescription="Keops Piramidi’nin bu LEGO® modelini yapıp sergilerken Antik Mısır dönemine gidin.", 
                    ProductPrice=850, 
                    ProductImg = "Keops Piramidi.jpg", 
                    Piece=1476, 
                    IsApproved=true, 
                    CategoryId = 2
                },
                new Product() 
                { 
                    ProductName="Tac Mahal", 
                    ProductDescription="Tac Mahal’in bu büyüleyici yap-sergile modeli. Mimari, seyahat ve tarih meraklılarını çok mutlu edecek.", 
                    ProductPrice=670, 
                    ProductImg = "Tac Mahal.jpg", 
                    Piece=2022, 
                    IsApproved=true,
                    CategoryId = 2
                },
                new Product() 
                { 
                    ProductName="Singapur", 
                    ProductDescription="Karmaşık bir sergileme modelini yaparken Singapur'da sihirli anları yeniden yaşayın veya bu hareketli şehre gittiğinizi hayal edin.", 
                    ProductPrice=500, ProductImg = "Singapur.jpg", 
                    Piece=827, 
                    IsApproved=true, 
                    CategoryId = 2
                },
                new Product() 
                { 
                    ProductName="LEGO Evi", 
                    ProductDescription="Tamamen LEGO'ya özgü LOGO Evi!", 
                    ProductPrice=600, 
                    ProductImg = "LEGO Evi.jpg", 
                    Piece=774,
                    IsApproved=true, 
                    CategoryId = 2
                },


                new Product() 
                { 
                    ProductName="LEGO® Titanik", 
                    ProductDescription="Yeni LEGO® Titanik ile rüyaların gemisinin modelini yap.", 
                    ProductPrice=1000, 
                    ProductImg = "Titanik.jpg", 
                    Piece=9090, 
                    IsApproved=true,
                    IsHome=true,
                    CategoryId = 3
                },
                new Product() 
                { 
                    ProductName="Geleceğe Dönüş Zaman Makinesi", 
                    ProductDescription="En sevilen film serilerinden birinden, hayranları için harika bir model.", 
                    ProductPrice=1200, 
                    ProductImg = "Geleceğe Dönüş.jpg", 
                    Piece=10300, 
                    IsApproved=true,
                    CategoryId = 3
                },
                new Product() 
                { 
                    ProductName="Optimus Prime", 
                    ProductDescription="LEGO® Optimus Prime, gerçek Transformers robotları gibi birkaç basit adımda robottan kamyona dönüşür", 
                    ProductPrice=1100, 
                    ProductImg = "Optimus Prime.jpg", 
                    Piece=1508, 
                    IsApproved=true, 
                    CategoryId = 3
                },
                new Product() 
                { 
                    ProductName="Camp Nou – FC Barcelona", 
                    ProductDescription="Camp Nou, FC Barcelona hayranları için ikonik ve renkli bir görünüm sunuyor.", 
                    ProductPrice=1300, 
                    ProductImg = "CampNou.jpg", 
                    Piece=5509, 
                    IsApproved=true,
                    IsHome=true,
                    CategoryId = 3
                },
                new Product() 
                { 
                    ProductName="Real Madrid – Santiago Bernabéu Stadyumu", 
                    ProductDescription="LEGO® Santiago Bernabéu Stadyumu, hem Real Madrid C.F. hayranlarının hem LEGO hayranlarının gönlünü kazanıyor.", 
                    ProductPrice=1500, 
                    ProductImg = "Santiago Bernabeu.jpg", 
                    Piece=5876, 
                    IsApproved=true, 
                    CategoryId = 3
                },
                new Product() 
                { 
                    ProductName="Harry Potter ve Hermione Granger", 
                    ProductDescription="Ünlü Harry Potter™ ve Hermione Granger™ karakterlerinin 26 cm boyunda, hareketli modelleriyle sihirli oyun ve sergileme eğlencesi.", 
                    ProductPrice=1150, 
                    ProductImg = "HarryPotter-Hermione.jpg", 
                    Piece=1673, 
                    IsApproved=true,
                    CategoryId = 4
                },
                new Product() 
                { 
                    ProductName="Ev Cini Dobby", 
                    ProductDescription="Genç Harry Potter™ hayranları, Büyücülük Dünyası’ndan sevilen bir karakterin figürünü LEGO® parçalarıyla inşa edip sergileyebilir.", 
                    ProductPrice=1250, 
                    ProductImg = "Dobby.jpg", 
                    Piece=5129, 
                    IsApproved=true, 
                    IsHome = true, 
                    CategoryId = 4
                },
                new Product() 
                { 
                    ProductName="Hogwarts Ekspresi ve İstasyonu", 
                    ProductDescription="Hagrid™’in Hogsmeade™ İstasyonu’na varan Hogwarts™ öğrencilerini karşıladığı unutulmaz sahneyi canlandırın.", 
                    ProductPrice=1400, 
                    ProductImg = "Hogwarts Ekspresi.jpg", 
                    Piece=165, 
                    IsApproved=true,
                    IsHome = true, 
                    CategoryId = 4
                },
                new Product() 
                { 
                    ProductName="Hogwarts™ Şatosu ve Bahçesi", 
                    ProductDescription="Hogwarts™ Şatosu ve Bahçesi’nin ilk LEGO® modeliyle büyüleyici bir yapım deneyiminin keyfini çıkarın.", 
                    ProductPrice=1650, 
                    ProductImg = "Hogwarts Satosu ve Bahçesi.jpg", 
                    Piece=403, 
                    IsApproved=true,
                    IsHome = true,
                    CategoryId = 4
                },
                new Product() 
                { 
                    ProductName="Uçan Ford Anglia", 
                    ProductDescription="Harry Potter™ ve Ron Weasley’nin Uçan Ford Anglia arabasıyla Hogwarts’a yaptıkları heyecan verici yolculuğunu canlandırın.", 
                    ProductPrice=1300, 
                    ProductImg = "Ford Anglia.png", 
                    Piece=2660, 
                    IsApproved=true,
                    IsHome = true,
                    CategoryId = 4
                },
                new Product() 
                { 
                    ProductName="Darth Vader™ Kaskı", 
                    ProductDescription="Yeni Darth Vader™ Kaskı ile Sith'in Kara Lordu'na bağlılığını göster.", 
                    ProductPrice=900, 
                    ProductImg = "Darth-Vader-Kaskı.jpg", 
                    Piece=834, 
                    IsApproved=true,
                    IsHome = true,
                    CategoryId=5
                },
                new Product() 
                { 
                    ProductName="Obi-Wan Kenobi™ ve Darth Vader", 
                    ProductDescription="Hayranlar, ünlü Obi-Wan Kenobi ve Darth Vader karakterlerinin LEGO® BrickHeadz™ versiyonlarını yaparken dramatik Star Wars: Obi-Wan Kenobi sahnelerini yeniden yaşayabilir.", 
                    ProductPrice=1300, 
                    ProductImg = "Obi-Wan Kenobi ve Darth Vader.jpg", 
                    Piece=260, 
                    IsApproved=true, 
                    CategoryId=5
                },
                new Product() 
                { 
                    ProductName="Ahsoka Tano", 
                    ProductDescription="Star Wars: Klon Savaşları karakteri Ahsoka Tano’nun bu inşa edilebilen 150. sürüm LEGO® BrickHeadz™ stili figürüyle cesur bir Jedi’a saygınızı gösterin.", 
                    ProductPrice=880, 
                    ProductImg = "Ahsoka Tano.jpg", 
                    Piece=164, 
                    IsApproved=true, 
                    CategoryId=5
                },
                new Product() 
                { 
                    ProductName="R2-D2", 
                    ProductDescription="Bu olağanüstü detaylı R2-D2 LEGO® droid figürüyle klasik Star Wars™ anlarını yeniden yaşayın.",
                    ProductPrice=950, 
                    ProductImg = "R2-D2.jpg", 
                    Piece=2314, 
                    IsApproved=true,
                    CategoryId=5
                },
                new Product() 
                { 
                    ProductName="AT-AT", 
                    ProductDescription="Tüm LEGO® Star Wars™ hayranlarının beklediği AT-AT!", 
                    ProductPrice=1000, 
                    ProductImg = "AT-AT.jpg", 
                    Piece=6785, 
                    IsApproved=true, 
                    CategoryId=5
                },
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();


            var bolgeler = new List<Region>()
            {
                new Region() { RegionName="Marmara"},
                new Region() { RegionName="Ege"},
                new Region() { RegionName="Akdeniz"},
                new Region() { RegionName="Karadeniz"},
                new Region() { RegionName="Güney Doğu Anadolu"},
                new Region() { RegionName="İç Anadolu"},
                new Region() { RegionName="Doğu Anadolu"},
            };

            foreach (var bolge in bolgeler)
            {
                context.Regions.Add(bolge);
            }
            context.SaveChanges();


            var kargolar = new List<Cargo>()
            {
                new Cargo() 
                { 
                    CargoName="Aras Kargo", 
                    WorkingHours="10.00 - 18.00", 
                    CargoPrice=10 , 
                    CargoImg="Aras Kargo.png",
                    IsApproved=true,
                    RegionId= 1
                },
                new Cargo() 
                { CargoName="Sürat Kargo", 
                    WorkingHours="09.00 - 18.00", 
                    CargoPrice=15 , 
                    CargoImg="Sürat Kargo.jpg",
                    IsApproved=true,
                    RegionId = 2
                },
                new Cargo() 
                { CargoName="Yurtiçi Kargo", 
                    WorkingHours="10.00 - 20.00", 
                    CargoPrice=30 , 
                    CargoImg="Yurtiçi Kargo.png",
                    IsApproved=true,
                    RegionId = 3
                },
                new Cargo() 
                { 
                    CargoName="PTT", 
                    WorkingHours="08.00 - 20.00", 
                    CargoPrice=25 , 
                    CargoImg="PTT Kargo.png",
                    IsApproved=true,
                    RegionId = 4
                },
                new Cargo() 
                { 
                    CargoName="MNG Kargo", 
                    WorkingHours="10.00 - 18.00", 
                    CargoPrice=20 , 
                    CargoImg="MNG Kargo.png",
                    IsApproved=true,
                    RegionId = 5
                },
                new Cargo() 
                { 
                    CargoName="UPS", 
                    WorkingHours="11.00 - 17.00", 
                    CargoPrice=35 , 
                    CargoImg="UPS.jpg",
                    IsApproved=true,
                    RegionId = 6
                },
                new Cargo() 
                { 
                    CargoName="FedEx", 
                    WorkingHours="12.00 - 18.00", 
                    CargoPrice=10 , 
                    CargoImg="FedEx.png",
                    IsApproved=true,
                    RegionId = 7
                }
            };

            foreach (var kargo in kargolar)
            {
                context.Cargos.Add(kargo);
            }
            context.SaveChanges();




            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() 
                { 
                    Name = "admin", 
                    Description = "Admin Rol" 
                };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() 
                { 
                    Name = "user", 
                    Description = "User Rol" 
                };
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "fahricoskun"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() 
                { 
                    Name = "fahri", 
                    Surname = "coskun", 
                    UserName = "fahricoskun", 
                    Email = "fahricoskun@gmail.com" 
                };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "wiodex"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser()
                {
                    Name = "wio",
                    Surname = "dex",
                    UserName = "wiodex",
                    Email = "wiodex@gmail.com"
                };
                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");
            }


            base.Seed(context);
        }
    }
}