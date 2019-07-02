using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Class {0}", args[0]);
        }
        
        static int Main(int a=5)
        {
            Console.WriteLine("Ha HA {0}", a);
            return 0;
        }
    }
}
