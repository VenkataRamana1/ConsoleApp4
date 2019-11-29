using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class RefDemo
    {
        static void Main()
        {
            string[] colors = {"Red","Blue","Black" };
            Console.WriteLine(colors[0]);
            ref string colornow = ref new RefDemo().Fav(2, colors);
            Console.WriteLine(colornow);
            colornow = "Green";
            Console.WriteLine(colornow);
            Console.WriteLine(colors);
            Console.ReadLine();
        }
        public ref string Fav(int fno, string[] colors)
        {
            if (colors.Length > 0 && colors.Length!=2)
                return ref colors[fno];
            throw new IndexOutOfRangeException($"{ nameof(fno)} is not found");
        }
    }
}
