using SIMAP.Models;
using System.Collections.ObjectModel;

namespace SIMAP.Services
{
    public class InventoryService
    {
        public ObservableCollection<Product> Products { get; private set; } = new();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
