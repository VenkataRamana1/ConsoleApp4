using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class substring
    {
        internal static void findallsubstring(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                StringBuilder sb = new StringBuilder(str.Length - i);
                for(int j = i; j < str.Length; ++j)
                {
                    sb.Append(str[j]);
                    Console.Write(sb+" ");
                }
                Console.ReadLine();
            }
        }
        public static void Main()
        {
            findallsubstring("abcd");
        }
    }
}
