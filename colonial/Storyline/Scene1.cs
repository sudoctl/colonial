using System;
using System.Threading;
using colonial.Commands;

namespace colonial.Storyline
{
    public class Scene1
    {
        public bool completed = false;
        public void Start()
        {
            Info.colonists++;
            completed = true;
            Console.WriteLine("!> A stranger hobbles into your camp, their clothes damp with blood");
            Thread.Sleep(2500);
            Console.WriteLine("!> They collapse near the campfire");
            Thread.Sleep(3000);
            Console.WriteLine("!> The builder offers his 'services'");
            RegisterCommands();
        }
        private static void RegisterCommands()
        {
            string[] commands =
            { 
                "services"
            };

            foreach (string com in commands)
            {
                List.Commands.Add(new Command { command = com });
            }
            
        }
    }
}