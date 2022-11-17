using System;
namespace DapperDemoMac
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductID { get; set; }
        public string Name { get; set;}
        public double Price { get; set; }
        public int CatergoryID { get; set; }
        public int Onsale { get; set; }
        public string StockLevel { get; set; }
    }
}

