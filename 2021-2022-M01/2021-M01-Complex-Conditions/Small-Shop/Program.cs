using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            var result = 0.0;
            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        result = quantity * 0.50;
                        break;
                    case "water":
                        result = quantity * 0.80;
                        break;
                    case "beer":
                        result = quantity * 1.20;
                        break;
                    case "sweets":
                        result = quantity * 1.45;
                        break;
                    case "peanuts":
                        result = quantity * 1.60;
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        result = quantity * 0.40;
                        break;
                    case "water":
                        result = quantity * 0.70;
                        break;
                    case "beer":
                        result = quantity * 1.15;
                        break;
                    case "sweets":
                        result = quantity * 1.30;
                        break;
                    case "peanuts":
                        result = quantity * 1.50;
                        break;
                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        result = quantity * 0.45;
                        break;
                    case "water":
                        result = quantity * 0.70;
                        break;
                    case "beer":
                        result = quantity * 1.10;
                        break;
                    case "sweets":
                        result = quantity * 1.35;
                        break;
                    case "peanuts":
                        result = quantity * 1.55;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
