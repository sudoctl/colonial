using System;

namespace colonial.Commands
{
    public class Builder
    {
        static Inventory _inventory = new Inventory();
        static Info info = new Info();
        public void Start()
        {
            Console.WriteLine("services>builder> What do you need me to build?");
            Listen();
        }
        void Listen()
        {
            Console.Write("services>builder> ");
            var readLine = Console.ReadLine();
            if (readLine != null) Process(readLine.ToLower());
        }

        void Process(string com)
        {
            switch (com)
            {
                case "house":
                {
                    if (_inventory.Amount("wood") <= 40)
                    {
                        Console.WriteLine($"services>builder> I need 40 wood to build this! (current: {_inventory.Amount("wood")})");
                        Listen();
                    }
                    else if (_inventory.Amount("stone") <= 20)
                    {
                        Console.WriteLine($"services>builder> I need 20 stone to build this! (current: {_inventory.Amount("stone")})");
                        Listen();
                    }
                    else
                    {
                        Info.homes++;
                        Info.colonists++;
                        Console.WriteLine($"services>builder> You now have {Info.homes} house(s)");
                        Listen();
                    }
                    break;
                }
                case "exit":
                    
                    break;
                default:
                    Console.WriteLine("services>builder> I cannot build this");
                    Listen();
                    break;
            }
        }

        void Build(string arg)
        {
            if (arg.Equals("house"))
            {
                
            }
        }
    }
}