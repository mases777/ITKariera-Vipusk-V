using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Peasant : Person
{
    private int productivity;
    public override int Age
    {
        get { return base.Age; }
        protected set
        {
            if (value > 110)
            {
                throw new ArgumentException("Age cannot be greater than 110!");
            }
            base.Age = value;
        }
    }

    public int Productivity
    {
        get { return productivity; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Productivity cannot be less or equal to 0!");
            }
            productivity = value;
        }
    }

    public Peasant(string name, int age, int productivity) : base(name, age)
    {
        this.Productivity = productivity;   
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {this.Name}");
        sb.AppendLine($"Age: {this.Age}");
        sb.AppendLine($"Productivity: {this.Productivity}");
        return sb.ToString().Trim();
    }
}

