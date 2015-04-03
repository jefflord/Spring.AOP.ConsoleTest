using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.AOP.ConsoleTest
{
    public class Logger
    {
        public static void WriteBegin(string s)
        {
            Console.WriteLine("Begin: " + s);
        }

        public static void WriteEnd(string s)
        {
            Console.WriteLine("End: " + s);
        }

    }
}
