using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Пациенти
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] splitOn = new char[] { ' ', ',' };

            List<string> patients = Console.ReadLine()
                .Split(splitOn, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "END OF PATIENTS")
            {
                switch (input)
                {
                    case "Add patient":
                        AddVisitor(patients);
                        break;
                    case "Add patient on position":
                        AddVisitorOnPosition(patients);
                        break;
                    case "Remove patient on position":
                        RemoveVisitorOnPosition(patients);
                        break;
                    case "Remove last patient":
                        RemoveLastVisitor(patients);
                        break;
                    case "Remove first patient":
                        RemoveFirstVisitor(patients);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", patients));
        }

        static void RemoveFirstVisitor(List<string> visitors)
        {
            visitors.RemoveAt(0);
        }

        static void RemoveLastVisitor(List<string> visitors)
        {
            visitors.RemoveAt(visitors.Count - 1);
        }

        static void RemoveVisitorOnPosition(List<string> visitors)
        {
            byte position = byte.Parse(Console.ReadLine());

            visitors.RemoveAt(position);
        }

        static void AddVisitorOnPosition(List<string> visitors)
        {
            string newVisitor = Console.ReadLine();
            byte position = byte.Parse(Console.ReadLine());

            visitors.Insert(position, newVisitor);
        }

        static void AddVisitor(List<string> visitors)
        {
            string newVisitor = Console.ReadLine();

            visitors.Add(newVisitor);
        }
    }
}
