using StoreApplication.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApplication.Data
{
    public class DummyData
    {
       public static List<Product> getProducts()
        {
            List<Product> products = new List<Product>(){
                new Product
                {
                    ProductName = "PC",
                    ProductDescription = "This is a high tech PC",
                    Category = "Technology",
                    Price = 1000,

                },new Product
                {
                    ProductName = "Glasses",
                    ProductDescription = "These glasses help with your vision",
                    Category = "Accessories",
                    Price = 30,

                },new Product
                {
                    ProductName = "Dress",
                    ProductDescription = "This is a summer dress",
                    Category = "Clothes",
                    Price = 20,

                },new Product
                {
                    ProductName = "Bed",
                    ProductDescription = "This is a really comfortable bed",
                    Category = "Home",
                    Price = 100,

                },new Product
                {
                    ProductName = "Table",
                    ProductDescription = "This is a dining table",
                    Category = "Home",
                    Price = 40,

                },
            };
            return products;
        }

    }

    
}