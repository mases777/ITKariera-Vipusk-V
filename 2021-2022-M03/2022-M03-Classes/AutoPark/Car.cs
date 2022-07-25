using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    public class Car
    {
        private string manufacturer;
        private string model;
        private double loadCapacity;
        private List<Part> parts;
        private double fuel;
        private static int ordersCount = 0;

        public Car(string manufacturer, string model, double loadCapacity)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.LoadCapacity = loadCapacity;
            this.Parts = new List<Part>();
            this.Fuel = 100;
        }
        public static int OrdersCount
        {
            get { return ordersCount; }
            set { ordersCount = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid manufacturer name!");
                }
                manufacturer = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid model name!");
                }
                model = value;
            }
        }
        public double LoadCapacity
        {
            get { return loadCapacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid load capacity!");
                }
                loadCapacity = value;
            }
        }
        public List<Part> Parts
        {
            get { return parts; }
            set { parts = value; }
        }


        public double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public void OrderCar(string manufacturer, string model, double loadCapacity)
        {
            Car car = new Car(manufacturer, model, loadCapacity);
            StartUp.cars.Add(model, car);
            ordersCount++;
        }

        public void AddPart(Part part)
        {
            this.Parts.Add(part);
        }
        public void AddMultipleParts(List<Part> parts)
        {
            foreach (var item in parts)
            {
                this.Parts.Add(item);
            }
        }

        public void RemovePartByName(string partName)
        {
            var newParts = new List<Part>(Parts.Where(x => x.Name != partName));
            Parts = newParts;
        }

        public string GetCarPrice()
        {
            return $"{this.Parts.Select(x => x.Price).Sum():f2}";
        }
        public bool ContainsPart(string partName)
        {
            foreach (var item in Parts)
            {
                if (item.Name == partName)
                {
                    return true;
                }
            }
            return false;
        }
        public string GetMostExpensivePart()
        {
            double searchPrice = double.Parse(string.Join("", this.Parts.Select(x => x.Price).OrderByDescending(x => x).Take(1)));
            foreach (var item in Parts)
            {
                if (item.Price == searchPrice)
                {
                    return item.ToString();
                }
            }
            return null;
        }

        public List<string> GetPartsWithPriceAbove(double price)
        {
            return Parts.Where(x => x.Price == price).Select(x => x.ToString()).ToList();
        }
        public void Drive(double distance)
        {
            if (this.Fuel - (loadCapacity * 0.2 * distance) >= 0)
            {
                this.Fuel -= loadCapacity * 0.2 * distance;
            }
            else
                throw new ArgumentException("Drive not possible!");
        }

        public void PrintCarByModel(string model)
        {
            foreach (var item in StartUp.cars)
            {
                if (model == item.Key)
                {
                    item.Value.ToString();
                }
            }
        }

        public override string ToString()
        {
            if (Parts.Count != 0)
            {
                return $@"{this.Model.ToUpper()} made by {this.Manufacturer}
Available parts:
{string.Join("\n", this.Parts.Select(x => x.ToString()))}
With total price of: {this.Parts.Select(x => x.Price).Sum():f2} lv.";
            }
            else
                return $@"{this.Model.ToUpper()} made by {this.Manufacturer}
Available parts:
With total price of: {this.Parts.Select(x => x.Price).Sum():f2} lv.";
        }
    }
}
