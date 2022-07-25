using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    public class Part
    {
        private string name;
        private double price;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Invalid part name!");
                }
                name = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price should be positive!");
                }
                price = value;
            }
        }
        public Part(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Part(string name)
        {
            this.Name = name;
            this.Price = 25;
        }
        public void CreatePart(string name, double price)
        {
            Part part = new Part(name, price);
            StartUp.parts.Add(name, part);
        }
        public void CreatePart(string name)
        {
            Part part = new Part(name, price);
            StartUp.parts.Add(name, part);
        }

        public override string ToString()
        {
            return $"-> {this.Name} - {this.Price:f2}";
        }
    }
}
