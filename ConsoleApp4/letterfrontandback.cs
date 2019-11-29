using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class letterfrontandback
    {
        static void Main()
        {
            string st = "The quick brown fox jumps over the lazy dog.";

            char[] ch = st.ToCharArray(0, 44);
            string st1 = ch[0] + st + ch[0];
            System.Console.WriteLine(st1);

            if (st.Length >= 0)
            {
                var str = st.Substring(0, 1);
                System.Console.WriteLine(str + st + str);
            }
        }
    }
}
