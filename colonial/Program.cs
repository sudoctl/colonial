using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using colonial.Commands;
using colonial.Storyline;
using Process = colonial.Commands.Process;

namespace colonial
{
    internal class Program
    {
        static Process _process = new Process();
        static Scene0 _scene0 = new Scene0();
        static Scene1 _scene1 = new Scene1();
        static NewHomes _newHomes = new NewHomes();
        
        public static void Main(string[] args)
        {
            _scene0.Start();
            Listen();
        }

        public static void Listen()
        {         
            Updates();
            Console.Write($"> ");
            var readLine = Console.ReadLine();
            if (readLine != null) _process.Input(readLine.ToLower());
        }

        static void Updates()
        {
            if (!_scene1.completed && (Process.inventory.Amount("wood") > 15))
            {
                _scene1.Start();
            }
            if (_scene1.completed && Info.homes == 1)
            {
                _newHomes.Start();
            }
            
        }
    }
}