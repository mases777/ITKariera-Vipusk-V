using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"People = {Person.Count()}");
            var Ivan = new Person("Ivan", 12);
            Console.WriteLine($"People = {Person.Count()}");
            var peter = new Person("Peter", 18);
            Console.WriteLine($"People = {Person.Count()}");
            var p = Math.PI / 2;            
        }
    }
}
