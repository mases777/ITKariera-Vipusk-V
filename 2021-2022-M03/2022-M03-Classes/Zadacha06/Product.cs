using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must be not null or empty.");
                }
                name = value;
            }
        }
        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Barcode must be not null or empty.");
                }
                barcode = value;
            }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be positive value.");
                }
                price = value;
            }
        }
        //private double quantity;

        //public double Quantity
        //{
        //    get { return quantity; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException("Quantity must be positive value.");
        //        }
        //        quantity = value;
        //    }
        //}

        public Product(string name, string barcode, double price)
        {
            this.Name = name;
            this.Barcode = barcode;
            this.Price = price;
            //this.Quantity = quantity;
        }
    }
}
