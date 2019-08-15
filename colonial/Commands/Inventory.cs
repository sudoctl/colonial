using System;
using System.Collections.Generic;

namespace colonial
{
    public class Inventory
    {
        public static IDictionary<string, int> _inventory = new Dictionary<string, int>();

        public Inventory()
        {
            if (!_inventory.ContainsKey("wood"))
            {
                _inventory.Add("wood", 0);
                _inventory.Add("stone", 0);
            }
        }

        public void Start()
        {
            Console.WriteLine("inventory> Type 'list' to see all commands");
            Listen();
        }

        void Listen()
        {
            Console.Write("inventory> ");
            var readLine = Console.ReadLine();
            if (readLine != null) Process(readLine.ToLower());
        }

        void Process(string com)
        {
            switch (com)
            {
                case "list":
                    Console.WriteLine("inventory> resources, food, weapons, utilities");
                    Listen();
                    break;
                case "resources":
                    Resources();
                    Listen();
                    break;
                case "exit":
                    Program.Listen();
                    break;
                default:
                    Console.WriteLine($"inventory> '{com}' is not a valid command");
                    Listen();
                    break;
            }
        }

        private void Resources()
        {
            var keys = new List<string>(_inventory.Keys);
            foreach(string key in keys)
            {
                if(key.Equals("wood") || key.Equals("stone"))
                    Console.WriteLine($"inventory>resources> {_inventory[key]} {key}");
            }         
        }

        public void Add(string item, int amt)
        {
            var keys = new List<string>(_inventory.Keys);
            foreach(string key in keys)
            {
                if (!key.Equals(item)) continue;
                _inventory[key] += amt;
            }
        }

        public void Remove(string item, int amt)
        {
            var keys = new List<string>(_inventory.Keys);
            foreach(string key in keys)
            {
                if (!key.Equals(item)) continue;
                _inventory[key] -= amt;
            }
        }

        public int Amount(string item)
        {
            foreach(KeyValuePair<string, int> _item in _inventory)
            {
                if (!_item.Key.Equals(item)) continue;
                return _item.Value;
            }
            return 0;
        }
    }
}