using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;
        public Pharmacy(string name)
        {
            this.Name = name;
            this.medicines = new List<Medicine>();
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }
        public IReadOnlyList<Medicine> Medicines
        {
            get { return medicines; }            
        }

        public void Order(Medicine medicine)
        {
            medicines.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            if (medicines.Contains(medicine))
            {
                medicines.Remove(medicine);
                return true;
            }
            return false;
        }

        public double CalculateTotalPrice()
        {
            return medicines.Select(x => x.Price).Sum();
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            return medicines.OrderByDescending(x => x.Price).FirstOrDefault();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return medicines.OrderBy(x => x.Price).FirstOrDefault();
        }

        public void RenamePharmacy(string newName)
        {
            Name = newName;
        }

        public void SellAllMedicines()
        {
            medicines.Clear();
        }

        public override string ToString()
        {
            string answer = $"Pharmacy {this.Name} has {Medicines.Count} medicines and they are:";
            if (Medicines.Count > 0)
            {
                foreach (var item in medicines)
                {
                    answer += $"\nMedicine: {item.Name} with price {item.Price:f2}";
                }
                return answer;
            }
            return $"Pharmacy {this.Name} has 0 medicines and they are:\nN/A";
        }
    }
}
