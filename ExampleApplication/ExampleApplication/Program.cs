using System;
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
            new Program().OutputMonth();
        }
        public void OutputYear()
        {
            Console.WriteLine(DateTime.Now.Year);
        }
        public void OutputMonth()
        {
            Console.WriteLine(DateTime.Now.Month);
        }
    }
}
