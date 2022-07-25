using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private List<double> grades;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Student()
        {

        }

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"Student {name} has {grade:f2}.";
        }
    }
}
