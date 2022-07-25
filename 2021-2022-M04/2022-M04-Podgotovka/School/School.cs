using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        public School()
        {

        }

        public School(string name)
        {
            this.Name = name;
            this.Students = new List<Student>() ;
        }

        public void AddStudent(string name, double grade)
        {
            Student student = new Student(name, grade);
            students.Add(student);
        }

        public double AverageResultInRange(int start, int end)
        {
            double sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += students[i].Grade;
            }
            return sum / (end - start + 1);
        }


        public List<string> RemoveStudentsByGrade(double grade)
        {
            List<string> names = students.FindAll(x => x.Grade < grade).Select(x => x.Name).ToList();
            students.RemoveAll(x => x.Grade < grade);
            return names;
        }

        public List<Student> SortAscendingByName()
        {
            return students.OrderBy(x => x.Name).ToList();           
        }

        public List<Student> SortDescendingByGrade()
        {
            return students.OrderByDescending(x => x.Grade).ToList(); 
        }

        public bool CheckStudentIsInSchool(string name)
        {
            Student student = students.Find(x => x.Name == name);
            return student != null ? true : false;
        }

        public string[] ProvideInformationAboutAllStudents()
        {
            string[] printInfo = new string[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                printInfo[i] = students[i].ToString();
            }
            return printInfo;
        }

    }
}
