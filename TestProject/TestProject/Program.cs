using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int y1 = 25;
            char sym1 = '@';
            Console.SetCursorPosition(x1,y1);
            Console.Write(sym1);

            int x2 = 50;
            int y2 = 8;
            char sym2 = '&';
            Console.SetCursorPosition(x2, y2);
            Console.Write(sym2);

            Console.Read();
        }
    }
}
