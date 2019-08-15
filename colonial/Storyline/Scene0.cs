using System;
using System.Threading;
using colonial.Commands;

namespace colonial.Storyline
{
    public class Scene0
    {
        public bool completed;
        public void Start()
        {
            completed = true;
            Console.WriteLine("!> You slowly open your eyes, blinded by the powerful light of the sun");
            Thread.Sleep(2300);
            Console.WriteLine("!> You stand on a beach surrounding a lagoon that leads back out into the swirling sea");
            Thread.Sleep(3000);
            Console.WriteLine("!> A deep dense foreset lies ahead.");
            Thread.Sleep(2100);
            Console.WriteLine("!> You take your first tentative steps into the treeline");
            Thread.Sleep(2600);
            Console.WriteLine("!> You walk until you find a clearing, where you decide to make a camp");
            Thread.Sleep(4000);
            Console.WriteLine("!> It occurs to you to 'gather' materials to build a shelter");

            RegisterCommands();
            
        }

        private static void RegisterCommands()
        {
            string[] commands =
            { 
                "help",
                "gather", 
                "inventory", 
                "exit"
            };

            foreach (string com in commands)
            {
                List.Commands.Add(new Command { command = com });
            }
            
        }
    }
}