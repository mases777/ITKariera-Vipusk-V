using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Person
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
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be positive value.");
                }
                age = value;
            }
        }
        private static int counter = 0;
        public static int Count()
        {
            return counter;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            counter++;
        }
    }
}
