﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO, USER");
            new Program().OutputYear();
        }
        public void OutputYear()
        {
            Console.WriteLine(DateTime.Now.Year);
        }
        public void OutputDay()
        {
            Console.WriteLine(DateTime.Now.Day);
        }
        public void OutputTime()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
        public void OutputAll()
        {
            OutputYear();
            OutputDay();
            OutputTime();
        }
    }
}
