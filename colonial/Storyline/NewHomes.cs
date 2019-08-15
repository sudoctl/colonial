using System;
using System.Threading;
using colonial.Commands;

namespace colonial.Storyline
{
    public class NewHomes
    {
        private bool completed;
        private Info info = new Info();
        public void Start()
        {
            completed = true;
            Console.WriteLine("!> The new homes will attract others");
            Thread.Sleep(2500);
            Console.WriteLine($"!> Your population grows to {Info.colonists}");
            Thread.Sleep(3000);
            
        }
    }
}