using System;
namespace DapperDemoMac
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, double price, int CatergoryID);

        public void UpdateProduct(int productID, string updatedName);

        public void DeleteProduct(int productID);
    }
}

