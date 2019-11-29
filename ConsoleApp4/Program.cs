using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 1, z;
            Console.Write(x + " " + y + " ");
            
            for (int i = 2; i < 100; i++)
            {
                z = x + y;
                Console.Write(z+ " ");
                x = y;
                y = z;
             }
            
            Console.ReadLine();
        }
    }
}
