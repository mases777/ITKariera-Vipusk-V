using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Store
    {
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Invalid store name!");
                }
                name = value;
            }
        }
        List<Car> cars = new List<Car>();

        public IReadOnlyCollection<Car> Cars
        {
            get { return cars; }
        }

        public Store(string name)
        {
            Name = name;
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public bool SellCar(Car car)
        {
            Car newCar = cars.Find(x => x.Number == car.Number);
            if (newCar != null)
            {
                cars.Remove(newCar);
                return true;
            }
            return false;
        }

        public double CalculateTotalPrice()
        {
            return cars.Select(x => x.Price).Sum();
        }

        public Car GetCarWithHighestPrice()
        {
            return cars.OrderByDescending(x => x.Price).FirstOrDefault();

            //Car newCar = null;
            //double price = double.MinValue;
            //foreach (Car car in cars)
            //{
            //    if (car.Price > price)
            //    {
            //        price = car.Price;
            //        newCar = car;
            //    }
            //}

            //return newCar;
        }

        public Car GetCarWithLowestPrice()
        {
            return cars.OrderBy(x => x.Price).FirstOrDefault();

            //Car newCar = null;
            //double price = double.MaxValue;
            //foreach (Car car in cars)
            //{
            //    if (car.Price < price)
            //    {
            //        price = car.Price;
            //        newCar = car;
            //    }
            //}

            //return newCar;
        }

        public void RenameStore(string newName)
        {
            Name = newName;
        }

        public void SellAllCars()
        {
            cars.Clear();
        }

        public override string ToString()
        {
            string answer = $"Store {Name} has {Cars.Count} car/s:";
            if (Cars.Count > 0)
            {
                foreach (var item in cars)
                {
                    answer += $"\nCar number {item.Number} costs {item.Price:F2}";
                }
                return answer;
            }
            return $"Store {Name} has no available cars.";
        }
    }
}
