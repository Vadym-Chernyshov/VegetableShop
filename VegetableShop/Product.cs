using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop
{
    internal class Product(decimal basePrice)
    {
        public virtual decimal BasePrice { get; set; } = basePrice;
        protected virtual string Name { get; set; } = "Product";
        public virtual string PublicInfo() => $"Product: {Name}, Price: {BasePrice}";                   
    }
    //вирішив трохи розширити класом для продуктів які зважуються
    //який теж йде від Product
    internal class ProductByWeight : Product
    {
        protected int Count { get; set; }
        protected decimal OnePrice { get; set; }        
        public ProductByWeight(decimal basePrice, int count) : base(basePrice)
        { //поясненння: перестановка значень потрібна для можливості розрахунку
            OnePrice = basePrice;
            BasePrice = OnePrice * count;
            Count = count;           
        }
        public override string PublicInfo()
        {
            return $"Product: {Name}, Price: {OnePrice}, Count: {Count}, Total price: {BasePrice}";
        }
    }
    //Тепер створюємо класи продуктів розподіляючи Ім'я
    //та вказуємо правильні залежності від Product та ProductByWeight
    internal class Tomato(decimal basePrice) : Product(basePrice)
    {
        protected override string Name { get; set; } = "Tomato";
    }

    internal class Carrot(decimal basePrice) : Product(basePrice)
    {
        protected override string Name { get; set; } = "Carrot";
    }

    internal class Potato(decimal basePrice, int count) : ProductByWeight(basePrice, count)
    {
        protected override string Name { get; set; } = "Potato";
    }


    internal class Cucumber(decimal basePrice, int count) : ProductByWeight(basePrice, count)
    {
        protected override string Name { get; set; } = "Cucumber";
    }

}
