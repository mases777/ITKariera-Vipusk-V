using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    public void Start()
    {
        Controller controller = new Controller();

        List<string> input = Console.ReadLine().Split(' ').ToList();
        try
        {
            while (input[0] != "End")
            {

                switch (input[0])
                {
                    case "Village":
                        Console.WriteLine(controller.ProcessVillageCommand(input.Skip(1).Take(input.Count - 1).ToList()));
                        break;
                    case "Settle":
                        Console.WriteLine(controller.ProcessSettleCommand(input.Skip(1).Take(input.Count - 1).ToList()));
                        break;
                    case "Rebel":
                        Console.WriteLine(controller.ProcessRebelCommand(input.Skip(1).Take(input.Count - 1).ToList()));
                        break;
                    case "Day":
                        Console.WriteLine(controller.ProcessDayCommand(input.Skip(1).Take(input.Count - 1).ToList()));
                        break;
                    case "Attack":
                        Console.WriteLine(controller.ProcessAttackCommand(input.Skip(1).Take(input.Count - 1).ToList()));
                        break;
                    case "Info":
                        Console.WriteLine(controller.ProcessInfoCommand(input.Skip(1).Take(input.Count - 1).ToList()));
                        break;
                }
                input = Console.ReadLine().Split(' ').ToList();

            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message); //PERROR
        }
        Console.WriteLine(controller.ProcessEndCommand());
    }
}

