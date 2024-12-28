using System.Collections.Generic;
namespace Dz15
{
    public abstract class Product
    {
        public string Name 
        { 
            get; 
        }


        protected decimal BasePrice 
        { 
            get; 
        }

        protected Product(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public abstract decimal Price();

        public override string ToString()
        {
            return $"Product: {Name}, Price: {BasePrice}";
        }
    }

    public class Carrot : Product
    {
        public Carrot(decimal basePrice) : base("Carrot", basePrice) 
        { 
        }

        public  override decimal Price() => BasePrice;
    }

    public class Potato : Product
    {
        public int Count 
        { 
            get; 
        }

        public Potato(decimal basePrice, int count) : base("Potato", basePrice)
        {
            Count = count;
        }

        public override decimal Price() => BasePrice * Count;

        public override string ToString()
        {
            return base.ToString() + $", Count: {Count}, Total price: {Price()}";
        }
    }


    public class Cucumber : Product
    {
        public int Count 
        { 
            get; 
        }

        public Cucumber(decimal basePrice, int count) : base("Cucumber", basePrice)
        {
            Count = count;
        }

        public override decimal Price() => BasePrice * Count;

        public override string ToString()
        {
            return base.ToString() + $", Count: {Count}, Total price: {Price()}";
        }
    }

    public class Tomato : Product
    {
        public Tomato(decimal basePrice) : base("Tomato", basePrice) 
        { 
        }

        public override decimal Price() => BasePrice;
    }

    public class VegetableShop
    {
        private readonly List<Product> Products = new();

        public void Add(IEnumerable<Product> products)
        {
            Products.AddRange(products);
        }

        public void Info()
        {
            decimal totalPrice = 0;

            foreach (var product in Products)
            {
                Console.WriteLine(product);
                totalPrice += product.Price();
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            var products = new List<Product>
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)
        };

            var shop = new VegetableShop();
            shop.Add(products);

            shop.Info();
        }
    }
}