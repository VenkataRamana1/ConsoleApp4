using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class duplicate
    {
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
        static void dclose()
        {
            removeduplicate("venkataramana");
        }
        static void Main()
        {
            removeduplicate("ramana");
            dclose();
            Console.ReadLine();
        }
        
    }
}
