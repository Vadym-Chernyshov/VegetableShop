using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop
{
    internal class VegetableShop
    {
        public List<Product> Products { get; set; } = [];

        public bool ProductAvailability() => Products.Count > 0;
        private decimal TotalCost() => Products.Sum(x => x.BasePrice);
        public void AddProducts(List<Product> products) => Products.AddRange(products);
        public void PrintProductsInfo()
        {
            if (ProductAvailability())
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Product product in Products)
                {
                    stringBuilder.AppendLine(product.PublicInfo());
                }

                Console.WriteLine(stringBuilder);
                Console.WriteLine($"Total products price: {TotalCost()}");
            }
            else Console.WriteLine("Ти забув щось купити");
        }
    }
}
