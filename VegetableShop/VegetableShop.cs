using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop
{
    internal class VegetableShop
    {
        private List<Product> Products { get; set; } = [];        
        private decimal TotalCost() => Products.Sum(x => x.BasePrice);
        public void AddProducts(List<Product> products) => Products.AddRange(products);
        public void PrintProductsInfo()
        {
            if (Products.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Product product in Products)
                {
                    stringBuilder.AppendLine(product.PublicInfo());
                }

                Console.WriteLine(stringBuilder);
                Console.WriteLine($"Total products price: {TotalCost()}");
            }
            else Console.WriteLine(); //нічого не показуємо
        }
    }
}
