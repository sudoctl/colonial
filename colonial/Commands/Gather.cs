using System;
using System.Diagnostics;

namespace colonial.Commands
{
    public class Gather
    {
        Inventory _inventory = new Inventory();
        public void Start()
        {
            Console.WriteLine("gather> Please input a material");
            Listen();
        }

        void Listen()
        {
            Console.Write("gather> ");
            var readLine = Console.ReadLine();
            if (readLine != null) Process(readLine.ToLower());
        }

        void Process(string com)
        {
            switch (com)
            {
                case "wood":
                    _inventory.Add("wood", 1);
                    Console.WriteLine($"gather> You now have {_inventory.Amount("wood")} wood");
                    Listen();
                    break;
                case "stone":
                    _inventory.Add("stone", 1);
                    Console.WriteLine($"gather> You now have {_inventory.Amount("stone")} stone");
                    Listen();
                    break;
                case "materials":
                    Console.WriteLine("gather> wood, stone");
                    Listen();
                    break;
                case "exit":
                    Program.Listen();
                    break;
                default:
                    Console.WriteLine($"gather> You search around but there is no {com} in sight");
                    Listen();
                    break;
            }
        }
    }
}