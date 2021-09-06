using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
           {
               new Category(){Name="Elektronik",Description="Elektronik ürünleri"},
               new Category(){Name="Moda",Description="Moda ürünleri"},
               new Category(){Name="Kırtasiye Ofis",Description="Kırtasiye Ofis ürünleri"},
               new Category(){Name="Spor",Description="Spor ürünleri"},
               new Category(){Name="Kozmetik",Description="Kozmetik ürünleri"}
           };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Apple Mack Book Pro ",Description="APPLE MYD82TU/A MacBook Pro 13.3''/Apple M1/256GB SSD/Laptop Uzay Grisi",Price=12369,Stock=200,IsApproved=true,CategoryId=1,IsHome=true,Image="1.jpg"},
                new Product(){Name="Huawei P-Smart Pro",Description="Huawei P Smart Pro Akıllı Telefon, Siyah, 128 GB",Price=2730,Stock=3500,IsApproved=true,CategoryId=1,IsHome=true,Image="4.jpg"},
                new Product(){Name="Canon EOS 2000D",Description="CANON EOS 2000D + 18-55 mm Dijital SLR Fotoğraf Makinesi",Price=3799,Stock=120,IsApproved=true,CategoryId=1,IsHome=true,Image="3.jpg"},
                new Product(){Name="Steelseries Rival 110 Mouse",Description="Steelseries Rival 110 Mouse",Price=500,Stock=2000,IsApproved=true,CategoryId=1,IsHome=true,Image="4.jpg"},
                new Product(){Name="Steelseries Rival 110 Mouse",Description="Samsung LC24RG50FQMXUF 24 144Hz (Display+HDMI) FULL HD FreeSync Kavisli Oyuncu Monitör",Price=1500,Stock=392,IsApproved=true,CategoryId=1,IsHome=true,Image="5.jpg"},

                new Product(){Name="Casio MTP-V002D-1BUDF",Description="Casio MTP-V002D-1BUDF Standart Erkek Kol Saati",Price=224,Stock=1500,IsApproved=true,CategoryId=2,Image="1.jpg"},
                new Product(){Name="Nibosi Chronograph",Description="Nibosi Chronograph Erkek Saati Su Geçirmez Paslanmaz Çelik",Price=228,Stock=100,IsApproved=true,CategoryId=2,Image="3.jpg"},
                new Product(){Name="Burberry Bu9005 ",Description="Burberry Bu9005 Kol Saati",Price=897,Stock=5,IsApproved=true,CategoryId=2,Image="3.jpg"},

                new Product(){Name="Noowa Çalışma Masası 60 x 90 cm",Description="Noowa Çalışma Masası 60 x 90 cm",Price=119,Stock=50,IsApproved=false,CategoryId=3,Image="1.jpg"},
                new Product(){Name="Plus Aksesuar Ahşap Kitaplık",Description="Plus Aksesuar Ahşap Doğal Masif 5 Katlı Raf Kitaplık 5 Raflı ",Price=519,Stock=20,IsApproved=true,CategoryId=3,Image="3.jpg"},
                new Product(){Name="3A Metal Ofis Seti 5'li Siyah Renk",Description="3A Metal Ofis Seti 5'li Siyah Renk",Price=109,Stock=50,IsApproved=true,CategoryId=3,Image="3.jpg"},

                new Product(){Name="Dynamic A300 Aero Motorlu Katlanabilen Koşu Bandı",Description="Dynamic A300 Aero Motorlu Katlanabilen Koşu Bandı",Price=2527,Stock=45,IsApproved=true,CategoryId=4,IsHome=true,Image="1.jpg"},
                new Product(){Name="Ümit 2613 Arcus 26 Jant Disk Fren Dağ Bisikleti",Description="Ümit 2613 Arcus 26 Jant Disk Fren Dağ Bisikleti",Price=1650,Stock=10,IsApproved=false,CategoryId=4,Image="3.jpg"},
                new Product(){Name="Albastar Tam Takım Hobi Kıyı Olta Seti ",Description="Albastar Tam Takım Hobi Kıyı Olta Seti ",Price=170,Stock=45,IsApproved=true,CategoryId=4,Image="3.jpg"},

                new Product(){Name="Slazenger Active Sport Mavi 125 Ml Erkek Parfüm",Description="Slazenger Active Sport Mavi 125 Ml Erkek Parfüm",Price=70,Stock=70,IsApproved=true,CategoryId=5,Image="1.jpg"},
                new Product(){Name="Procsin Yüz Koruyucu Faktör 50+ Güneş Kremi 50 ml",Description="Procsin Yüz Koruyucu Faktör 50+ Güneş Kremi 50 ml",Price=45,Stock=100,IsApproved=false,CategoryId=5,Image="3.jpg"},
                new Product(){Name="Pantene 2'si 1 Arada Şampuan",Description="Pantene 2'si 1 Arada Şampuan",Price=29,Stock=40,IsApproved=false,CategoryId=5,Image="3.jpg"},
                


            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}