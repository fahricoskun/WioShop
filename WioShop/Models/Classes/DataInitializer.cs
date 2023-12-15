using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { CategoryName="Marvel"},
                new Category() { CategoryName="Architecture"},
                new Category() { CategoryName="Classic"},
                new Category() { CategoryName="Disney"},
                new Category() { CategoryName="DC"},
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() { ProductName="Hulkbuster", ProductDescription="Iron Man'in güçlü ve mega zırhı Hulkbuster!", ProductPrice=750, ProductImg = ""},
                new Product() { ProductName="Black Panther", ProductDescription = "Bu zarif büstte Kral T’Challa eliyle ikonik Yaşasın Wakanda selamını veriyor.", ProductPrice=600, ProductImg = ""},
                new Product() { ProductName="Thor'un Çekici", ProductDescription = "Marvel Studios Sonsuzluk Destanı’ndan destansı boyutlar, etkileyici detaylar ve simgeleşmiş parçalarla tasarlanan Thor'un efsanevi çekici.", ProductPrice=1000, ProductImg = ""},
                new Product() { ProductName="Iron Man Figürü", ProductDescription = "Marvel hayranları, bu inşa edilebilen, tam eklemli Iron Man’i gerçeği gibi hareket ettirebilir ve poz verdirebilir.", ProductPrice=800, ProductImg = ""},
                new Product() { ProductName="Sonsuzluk Eldiveni", ProductDescription = "Marvel Avengers'ın yetişkin hayranları, bu göz alıcı yap-sergile LEGO® Marvel Sonsuzluk Eldivenini çok beğenecek.", ProductPrice=900, ProductImg = ""},

                new Product() { ProductName="Himeji Kalesi", ProductDescription="Bu yapım ve sergileme setiyle Japonya’nın en büyük kalesinin dayanıklılığını ve görkemli güzelliğini kutlayın.", ProductPrice=540, ProductImg = ""},
                new Product() { ProductName="Hulkbuster", ProductDescription="Keops Piramidi’nin bu LEGO® modelini yapıp sergilerken Antik Mısır dönemine gidin.", ProductPrice=820, ProductImg = ""},
                new Product() { ProductName="Hulkbuster", ProductDescription="Tac Mahal’in bu büyüleyici yap-sergile modeli. Mimari, seyahat ve tarih meraklılarını çok mutlu edecek.", ProductPrice=670, ProductImg = ""},
                new Product() { ProductName="Hulkbuster", ProductDescription="Karmaşık bir sergileme modelini yaparken Singapur'da sihirli anları yeniden yaşayın veya bu hareketli şehre gittiğinizi hayal edin.", ProductPrice=500, ProductImg = ""},
                new Product() { ProductName="Hulkbuster", ProductDescription="Tamamen LOGO'ya özgü LOGO Evi!", ProductPrice=600, ProductImg = ""},

            };

            base.Seed(context);
        }
    }
}