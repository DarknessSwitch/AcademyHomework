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
            new Program().OutputYear();
        }
        public void OutputYear()
        {
            Console.WriteLine(DateTime.Now.Year);
        }
    }
}
