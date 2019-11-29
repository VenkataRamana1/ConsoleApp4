using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Mulwithout
    {
         static void Main()
        {
            
            int Mul(int x, int y)
            {
                int value = 0;
                x = 2;
                y = 2;
                for (int z = 0; z <= y; z++)
                {
                   
                     value = value+x;
                    
                }
                return value;
            }
        }
    }
}
