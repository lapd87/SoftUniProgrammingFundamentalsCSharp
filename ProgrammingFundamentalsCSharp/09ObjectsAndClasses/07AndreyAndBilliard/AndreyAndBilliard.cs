namespace AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product> { };

            for (int i = 0; i < n; i++)
            {
                Product currentProduct = ReadProduct();

                if (products.Any(p => p.Name.Equals(currentProduct.Name)))
                {
                    int index = products.IndexOf(products.FirstOrDefault(p => p.Name.Equals(currentProduct.Name)));

                    products.RemoveAt(index);
                }

                products.Add(currentProduct);
            }

            List<Buyer> orders = ReadBuyersOrders(products);

            PrintBill(orders);
        }

        private static void PrintBill(List<Buyer> orders)
        {
            foreach (var buyer in orders.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{buyer.Name}");

                foreach (var product in buyer.Order)
                {
                    Console.WriteLine($"-- {product.Key.Name} - {product.Value}");
                }

                Console.WriteLine($"Bill: {buyer.Bill():f2}");
            }

            Console.WriteLine($"Total bill: {orders.Sum(t => t.Bill()):f2}");
        }

        private static List<Buyer> ReadBuyersOrders(List<Product> products)
        {
            string input = Console.ReadLine();

            List<Buyer> buyersOrders = new List<Buyer> { };

            while (input != "end of clients")
            {
                string[] buyerProductQuantity = input
                        .Trim()
                        .Split(new string[] { "-", "," }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

                Product orderedProduct = new Product();

                orderedProduct.Name = buyerProductQuantity[1];

                if (products.Any(n => n.Name.Equals(orderedProduct.Name)))
                {
                    int indexPrice = products.IndexOf(products.FirstOrDefault(n => n.Name.Equals(orderedProduct.Name)));

                    orderedProduct.Price = products[indexPrice].Price;

                    Buyer currentBuyer = new Buyer();

                    currentBuyer.Name = buyerProductQuantity[0];
                    currentBuyer.Order = new Dictionary<Product, decimal> { };

                    if (!buyersOrders.Any(n => n.Name.Equals(currentBuyer.Name)))
                    {
                        buyersOrders.Add(currentBuyer);
                    }

                    int indexBuyer = buyersOrders.IndexOf(buyersOrders.FirstOrDefault(n => n.Name.Equals(currentBuyer.Name)));

                    if (!buyersOrders[indexBuyer].Order.Any(p => p.Key.Name.Equals(orderedProduct.Name)))
                    {
                        buyersOrders[indexBuyer].Order.Add(orderedProduct, 0);
                    }

                    Product indexOrder = buyersOrders[indexBuyer].Order.FirstOrDefault(p => p.Key.Name.Equals(orderedProduct.Name)).Key;

                    buyersOrders[indexBuyer].Order[indexOrder] += decimal.Parse(buyerProductQuantity[2]);
                }

                input = Console.ReadLine();
            }

            return buyersOrders;
        }

        private static Product ReadProduct()
        {
            string[] input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { "-" }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            Product currentProduct = new Product();

            currentProduct.Name = input[0];
            currentProduct.Price = decimal.Parse(input[1]);

            return currentProduct;
        }
    }

    internal class Buyer
    {
        public string Name { get; set; }
        public Dictionary<Product, decimal> Order { get; set; }

        public decimal Bill()
        {
            decimal totalBill = 0;

            foreach (var item in Order)
            {
                totalBill += item.Key.Price * item.Value;
            }

            return totalBill;
        }
    }

    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}