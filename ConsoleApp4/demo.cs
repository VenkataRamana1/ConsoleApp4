using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class demo : AccessModifilersChildDemo
    {
        static void Main()
        {
            AccessModifilersChildDemo amcd = new AccessModifilersChildDemo();
            AccessModifiersDemo amd = new AccessModifiersDemo();
            
            amcd.Test(10);
            var str = amcd.status();
            Console.WriteLine(amcd.status());
            Console.ReadLine();
        }
    }
}
