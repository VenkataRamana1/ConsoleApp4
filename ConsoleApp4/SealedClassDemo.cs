using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SealedClassDemo
    {
        public sealed class SealedOne
        {
            void Message()
            {

                Console.WriteLine("Help me I am locked.");
            }
        }

        //Sealed Cannot be derived because of its nature 
        //class mess:SealedOne{

        //    }

    }
}
