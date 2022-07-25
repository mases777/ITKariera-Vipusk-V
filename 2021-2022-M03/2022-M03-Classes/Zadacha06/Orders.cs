using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Orders
    {
        private static Dictionary<Product, double> orders;

        static Orders()
        {
            orders = new Dictionary<Product, double>();
        }
        public static void Add(string barcode, string name, double price, double quantity)
        {
            var product = new Product(name, barcode,price);
            if (orders.ContainsKey(product))
            {
                orders[product] += quantity;
            }
            else
            {
                orders.Add(product, quantity);
            }
        }
        public static void Sell(string barcode, double quantity)
        {
            if (!orders.ContainsKey(orders.First(x => x.Key.Barcode == barcode).Key))
            {
                throw new ArgumentException("Please add your product first!");
            }
            var product = orders.First(x => x.Key.Barcode == barcode).Key;
            if (orders[product] < quantity)
            {
                throw new ArgumentException("Not enough quantity");
            }
            orders[product] -= quantity;
        }
        public static void Update(string barcode, double quantity)
        {
            if (!orders.ContainsKey(orders.First(x => x.Key.Barcode == barcode).Key))
            {
                throw new ArgumentException("Please add your product first!");
            }
            var product = orders.First(x => x.Key.Barcode == barcode).Key;
            orders[product] += quantity;
        }
        public static void PrintA()
        {
            var items = orders.OrderBy(x => x.Key.Name);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} ({item.Key.Barcode})");
            }
        }
        public static void PrintU()
        {
            var items = orders.Where(x => x.Value == 0);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} ({item.Key.Barcode})");
            }
        }
        public static void PrintD()
        {
            var items = orders.OrderByDescending(x => x.Value);
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} ({item.Key.Barcode})");
            }
        }
        public static double Calculate()
        {
            double total = 0;
            foreach (var item in orders)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }
    }
}
