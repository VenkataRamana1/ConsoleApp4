using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AccessModifiersDemo
    {
         private void Test()
        {
            Console.WriteLine("Hello. I am called");
        }
        internal void Test(string s)
        {
            Console.WriteLine("Hello. I am Internal Test");
        }

        protected void Test(string s,int i)
        {
            Console.WriteLine("Hello. I am Protected Test");
        }
        protected internal void Test(int i, string s)
        {
            Console.WriteLine("Hello. I am Protected internal Test");
        }
        public void Test(int i)
        {
            Console.WriteLine("Hello, I am Public Test.");
        }

        static void Main()
        {
            AccessModifiersDemo amd = new AccessModifiersDemo();
            //amd.Test();
           // amd.Test(10);
            Console.ReadLine();
        }
    }
}
