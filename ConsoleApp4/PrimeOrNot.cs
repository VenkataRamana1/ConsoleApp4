using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PrimeOrNot
    {
        static void Main()
        {
            int num = 10,i=0;
            for (i = 3; i < 3; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("It's not a prime");
                    break;
                }
            }
            if (i == num)
            {
                Console.WriteLine("{0} It's a Prime",num);
            }
            Console.ReadLine();
        }
 }
}
