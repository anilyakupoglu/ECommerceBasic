namespace ETicaretBasic.DAL.Migrations
{
    using ETicaretBasic.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ETicaretBasic.DAL.EntityFramework.ETicaretDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ETicaretBasic.DAL.EntityFramework.ETicaretDBContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){ CategoryName="Bilgisayar", Description="Bilgisayar Ürünleri",IsHome = true},
                new Category(){ CategoryName="Elektronik", Description="Elektronik Ürünleri",IsHome = true},
                new Category(){ CategoryName="Cep Telefonu", Description="Cep Telefonu Ürünleri",IsHome = true},
                new Category(){ CategoryName="Kamera", Description="Kamera Ürünleri",IsHome = true},
                new Category(){ CategoryName="Spor Outdoor", Description="Spor Outdoor Ürünleri",IsHome = true},
                new Category(){ CategoryName="Kişisel Bakım", Description="Kişisel Bakım Ürünleri",IsHome = true}
            };
            foreach (Category category in categories)
            {
                context.Categories.Add(category);
            }


            List<Product> products = new List<Product>()
            {
                new Product(){ProductName="Iphone 8 Cep Telefonu",Description="Iphone 8 çok güzel bir telefon onun hakkında bilgiler burada yazacak Iphone 8 çok güzel bir telefon onun hakkında bilgiler burada yazacak", Price=3000, IsActive=true, CategoryID=3, Stock=80,IsHome = true,Image="1.jpg"},
                new Product(){ProductName="Iphone 7 Cep Telefonu",Description="Iphone 7 çok güzel bir telefon onun hakkında bilgiler burada yazacak Iphone 7 çok güzel bir telefon onun hakkında bilgiler burada yazacak", Price=2000, IsActive=true, CategoryID=3, Stock=50,Image="2.jpg"},
                new Product(){ProductName="Apple MacBook Pro Dizüstü Bilgisayar",Description="Apple MacBook Pro çok güzel bir bilgisayar onun hakkında bilgiler burada yazacak Apple MacBook Pro çok güzel bir bilgisayar onun hakkında bilgiler burada yazacak", Price=8000, IsActive=true, CategoryID=1, Stock=50,IsHome = true,Image="3.jpg"},
                new Product(){ProductName="Acer Aspire N250 Dizüstü Bilgisayar",Description="Acer Aspire N250 çok güzel bir bilgisayar onun hakkında bilgiler burada yazacak Acer Aspire N250 çok güzel bir bilgisayar onun hakkında bilgiler burada yazacak", Price=6000, IsActive=true, CategoryID=1, Stock=250,Image="4.jpg"},
                new Product(){ProductName="Toshiba TS356 Dizüstü Bilgisayar",Description="Toshiba TS356 çok güzel bir bilgisayar onun hakkında bilgiler burada yazacak Toshiba TS356 çok güzel bir bilgisayar onun hakkında bilgiler burada yazacak", Price=7000, IsActive=true, CategoryID=1, Stock=120,IsHome = true,Image="5.jpg"},
                new Product(){ProductName="Canon EOS 250 Fotoğraf Makinesi",Description="Canon EOS 250 Fotoğraf Makinesi onun hakkında bilgiler burada yazacak Canon EOS 250 Fotoğraf Makinesi onun hakkında bilgiler burada yazacak", Price=3000, IsActive=true, CategoryID=4, Stock=50,IsHome=true,Image="6.jpg"},
                new Product(){ProductName="Privacy Parfüm",Description="Privacy Parfüm onun hakkında bilgiler burada yazacak Privacy Parfüm onun hakkında bilgiler burada yazacak", Price=80, IsActive=true, CategoryID=6, Stock=250,IsHome = true,Image="7.jpg"},
                 new Product(){ProductName="Delta Ağırlık Sehpası",Description="Delta Ağırlık Sehpası onun hakkında bilgiler burada yazacak Delta Ağırlık Sehpası onun hakkında bilgiler burada yazacak", Price=90, IsActive=true, CategoryID=5, Stock=250,IsHome = true,Image="8.jpg"}

            };

            foreach (Product product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}
