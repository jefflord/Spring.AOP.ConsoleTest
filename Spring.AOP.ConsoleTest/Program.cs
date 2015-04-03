using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging.Configuration;
using Spring.Context.Support;

namespace Spring.AOP.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
           

            IPerson obj = null;
            if (!true)
            {
                obj = new Person();
            }
            else
            {
                var appContext = ContextRegistry.GetContext();
                obj = (IPerson)appContext["AOPPerson"];
            }

            const int loops = 2000000;
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            Stopwatch stopwatch3 = Stopwatch.StartNew();

            stopwatch1.Restart();
            for (int x = 0; x < loops; x++)
            {
                obj.SpeedTest();
            }
            stopwatch1.Stop();

            Person realPerson = new Person();
            stopwatch2.Restart();
            for (int x = 0; x < loops; x++)
            {
                realPerson.SpeedTest();
            }
            stopwatch2.Stop();

            realPerson = new Person();
            stopwatch3.Restart();
            for (int x = 0; x < loops; x++)
            {
                realPerson.SpeedTestAOP();
            }
            stopwatch3.Stop();
            
            Console.WriteLine(stopwatch1.ElapsedMilliseconds);
            Console.WriteLine(stopwatch2.ElapsedMilliseconds);
            Console.WriteLine(stopwatch3.ElapsedMilliseconds);
            float percentDiff1 = (1 - (float)stopwatch2.ElapsedMilliseconds / stopwatch1.ElapsedMilliseconds) * 100;
            float percentDiff2 = (1 - (float)stopwatch2.ElapsedMilliseconds / stopwatch3.ElapsedMilliseconds) * 100;
            
            Console.WriteLine("native vs proxy:" + percentDiff1 + "%");
            Console.WriteLine("native vs postsharp:" + percentDiff2 + "%");
            //Console.ReadKey();

            //obj.SayHello();
            //Console.WriteLine(obj.GetAddress());
            //Console.WriteLine(obj.DoSomething(33, 22).ToString());

        }
    }
}
