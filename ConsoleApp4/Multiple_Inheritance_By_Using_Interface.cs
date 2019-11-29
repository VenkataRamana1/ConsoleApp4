using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Multiple_Inheritance_By_Using_Interface
    {
        static void Main()
        {
            Message msg = new Message();
            msg.message();
            Console.ReadLine();
        }
    }
    public  interface First_Message{
        void message();    
    }
    public interface Second_Message
    {
        void message();
    }
    public class Message : First_Message, Second_Message
    {
        public void message()
        {
            Console.WriteLine("Hello, I am here.");
        }
    }
}
