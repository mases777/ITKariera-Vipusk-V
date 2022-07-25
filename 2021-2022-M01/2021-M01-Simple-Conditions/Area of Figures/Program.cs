using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    var a = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * a);
                    break;
                case "rectangle":
                    var b = double.Parse(Console.ReadLine());
                    var c = double.Parse(Console.ReadLine());
                    Console.WriteLine(b * c);
                    break;
                case "circle":
                    var r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(Math.PI * r * r):f3}");
                    Console.WriteLine(Math.Round(Math.PI * r * r, 3));
                    break;
                case "triangle":
                    var d = double.Parse(Console.ReadLine());
                    var h = double.Parse(Console.ReadLine());
                    Console.WriteLine(d * h / 2);
                    break;
            }

            //if (figure == "square")
            //{
            //    var a = double.Parse(Console.ReadLine());
            //    Console.WriteLine(a * a);
            //}
            //else if (figure == "rectangle")
            //{
            //    var b = double.Parse(Console.ReadLine());
            //    var c = double.Parse(Console.ReadLine());
            //    Console.WriteLine(b * c);
            //}
            //else if (figure == "circle")
            //{
            //    var r = double.Parse(Console.ReadLine());
            //    Console.WriteLine(Math.PI * r * r);
            //}
            //else if (figure == "triangle")
            //{
            //    var d = double.Parse(Console.ReadLine());
            //    var h = double.Parse(Console.ReadLine());
            //    Console.WriteLine(d * h / 2);
            //}
        }
    }
}
