using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Car
    {
        int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 1000)
                {
                    throw new ArgumentException("Invalid car price!");
                }
                price = value;
            }
        }

        public Car(int number, double price)
        {
            Number = number;
            Price = price;
        }

        public override string ToString()
        {
            return $"Car number {Number} costs {Price:F2}";
        }
    }
}
