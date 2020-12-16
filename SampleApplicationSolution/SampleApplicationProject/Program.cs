using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplicationProject
{
     partial class Program
    {
        static void Main(string[] args)
        {
            new Program().PrintWelcome();
            Console.WriteLine("hello world");
            Console.WriteLine("another line");
            Console.ReadKey();
        }
    }
}
