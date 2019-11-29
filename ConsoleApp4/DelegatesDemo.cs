using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class DelegateMain
    {
        static void Main()
        {
            DelegatesDemo dd = new DelegatesDemo();
            DelegatesDemo.First_Deligate ddfd = new DelegatesDemo.First_Deligate(dd.func1);
            DelegatesDemo.First_Deligate ddfd1 = new DelegatesDemo.First_Deligate(dd.func2);
            DelegatesDemo.First_Deligate ddfd2 = new DelegatesDemo.First_Deligate(dd.func3);
            DelegatesDemo.First_Deligate ddfd3 = new DelegatesDemo.First_Deligate(dd.func4);

            ddfd();
            ddfd1();
            ddfd2();
            ddfd3();

            //Second Example DelegatesDemo2
            //Instantiating the class 
            DelegatesDemo2 dd2 = new DelegatesDemo2();
            //Invocing the methods by using the delegates
            DelegatesDemo2.Second_Delegate ddsd1 = new DelegatesDemo2.Second_Delegate(dd2.func1);
            DelegatesDemo2.Second_Delegate ddsd2 = new DelegatesDemo2.Second_Delegate(dd2.func2);
            DelegatesDemo2.Second_Delegate ddsd3 = new DelegatesDemo2.Second_Delegate(dd2.func3);
            DelegatesDemo2.Second_Delegate ddsd4 = new DelegatesDemo2.Second_Delegate(dd2.func4);

            //Invoking the local variables of the above instances.
            ddsd1();
            ddsd2();
            ddsd3();
            ddsd4();

            //Third Example Delegate3
            //Instantiating the class 
            DelegatesDemo3 dd3 = new DelegatesDemo3();
            //Invocing the methods by using the delegates
            DelegatesDemo3.Third_Delegate ddtd1 = new DelegatesDemo3.Third_Delegate(dd3.func1);
            DelegatesDemo3.Third_Delegate ddtd2 = new DelegatesDemo3.Third_Delegate(dd3.func2);
            DelegatesDemo3.Third_Delegate ddtd3 = new DelegatesDemo3.Third_Delegate(dd3.func3);
            DelegatesDemo3.Third_Delegate ddtd4 = new DelegatesDemo3.Third_Delegate(dd3.func4);

            //Invoking the local variables of the above instances.
            ddtd1();
            ddtd2();
            ddtd3();
            ddtd4();

            Console.ReadLine();
        }
    }
    //First Example 
    public class DelegatesDemo
    {
        public delegate void First_Deligate();

        public void func1()
        {
            Console.WriteLine("Hello I am delgate function 1");
        }
        public void func2()
        {
            Console.WriteLine("Hello I am delgate function 2");
        }
        public void func3()
        {
            Console.WriteLine("Hello I am delgate function 3");
        }
        public void func4()
        {
            Console.WriteLine("Hello I am delgate function 4");
        }
    }

    
   
    //Second Example 
    public class DelegatesDemo2
    {
        public delegate void Second_Delegate();

        public void func1()
        {
            Console.WriteLine("Hello...I am function one");
        }

        public void func2()
        {
            Console.WriteLine("Hello...I am function two");
        }

        public void func3()
        {
            Console.WriteLine("Hello...I am function three");
        }

        public void func4()
        {
            Console.WriteLine("Hello...I am function four");
        }
    }
    
    //Third Example
    public class DelegatesDemo3
    {
        //Delegate with parameters
        public delegate void Third_Delegate();

        public void func1()
        {
            Console.WriteLine("Hello...I am function 1");
        }

        public void func2()
        {
            Console.WriteLine("Hello...I am function 2");
        }

        public void func3()
        {
            Console.WriteLine("Hello...I am function 3");
        }

        public void func4()
        {
            Console.WriteLine("Hello...I am function 4");
        }
    }


    
}
