using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);




            Person ivan = new Person();

            ivan.Name = "Ivan";
            ivan.Age = 15;

            ivan.IntroduceYourself();

            Person dragan = new Person();
            dragan.Name = "Dragan";
            dragan.IntroduceYourself();
        }
    }
}
