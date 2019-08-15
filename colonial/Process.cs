using System;
using System.Diagnostics;

namespace colonial.Commands
{
    public class Process
    {
        Gather gather = new Gather();
        Services services = new Services();
        public static Inventory inventory = new Inventory();
        public void Input(string command)
        {
            bool commandExists = false;
            foreach (Command com in List.Commands)
            {
                if (com.command.Equals(command))
                    commandExists = true;
                
            }
            if (!commandExists)
            {
                Console.WriteLine($"> '{command}' is not a valid command");
                Program.Listen();
            }
            else
            {
                switch (command)
                {
                    case "gather":
                        gather.Start();
                        break;
                    case "inventory":
                        inventory.Start();
                        break;
                    case "exit":
                        Console.WriteLine("!> Are you sure you want to exit? (y/n)");
                        Console.Write("!> ");
                        var readLine = Console.ReadLine();
                        if (readLine != null && readLine.ToLower().Equals("y"))
                            Environment.Exit(1);
                        Program.Listen();
                        break;
                    case "help":
                        Console.WriteLine("help> Half of the journey is discovering where to go");
                        Program.Listen();
                        break;
                    case "services":
                        services.Start();
                        break;
                    default:
                        Console.WriteLine($"> '{command}' is not a valid command");
                        Program.Listen();
                        break;
                }
            }
        }
    }
}