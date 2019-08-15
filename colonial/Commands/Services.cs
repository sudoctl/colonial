using System;

namespace colonial.Commands
{
    public class Services
    {
        private Info info = new Info();
        Builder builder = new Builder();
        public void Start()
        {
            Console.WriteLine("services> You may access the services of your colony here");
            Listen();
        }
        void Listen()
        {
            Console.Write("services> ");
            var readLine = Console.ReadLine();
            if (readLine != null) Process(readLine.ToLower());
        }

        void Process(string com)
        {
            switch (com)
            {
                 case "builder":
                     builder.Start();
                     Listen();
                     break;
                 case "exit":
                     Program.Listen();
                     break;
                 default:
                     break;
            }
        }
    }
}