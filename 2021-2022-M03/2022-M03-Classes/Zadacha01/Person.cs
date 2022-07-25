using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                age = value; }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Здравейте! Аз съм {name} и съм на {age} години.");
        }


    }
}
