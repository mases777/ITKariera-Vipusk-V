﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if (gender == "m")
            {
                if (age >= 16) Console.WriteLine("Mr.");
                else Console.WriteLine("Master");
            }
            else
            {
                if (age >= 16) Console.WriteLine("Ms.");
                else Console.WriteLine("Miss");
            }
        }
    }
}
