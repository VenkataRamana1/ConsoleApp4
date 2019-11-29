using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class InheritanceDemo
    {
        static void Main()
        {
            Tyre tyre = new Tyre();
            string t = tyre.TyreType("Hello");
            Console.WriteLine(t);
            Lorry lo = new Lorry();
            lo.LorryTyreType();
            Bus bs = new Bus();
            bs.BusTyreType();
            Console.ReadLine();
        }
    }

    //Base class 
    class Tyre
    {
        internal string TyreType(string t)
        {
            return t;
        }

    }

    //Child Classes.
    class Lorry : Tyre
    {
        internal void LorryTyreType()
        {
            string t = TyreType("It is Tubeless Tyre.");
            Console.WriteLine("Lorry is big." + t);
        }
    }

    class Bus : Tyre
    {
        internal void BusTyreType()
        {
            string bt = TyreType("It is Tubeless Tyre.");
            Console.WriteLine("Bus is with red and white color." + bt);

        }


    }
}
