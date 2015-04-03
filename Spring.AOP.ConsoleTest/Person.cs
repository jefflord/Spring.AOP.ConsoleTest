using System;
using System.Threading;

namespace Spring.AOP.ConsoleTest
{
    
    public class Person : IPerson
    {

        [MethodTraceAspect]
        public int SpeedTestAOP()
        {
            Random random = new Random();
            return random.Next(4, 9999);

        }


        public int SpeedTest()
        {
            Random random = new Random();
            return random.Next(4, 9999);

        }


        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public string GetAddress()
        {
            string retVal;
            retVal = "Route 66";
            return retVal;
        }

        public int DoSomething(int num, int num2)
        {
            int calc;
            calc = num + num2;
            return calc;
        }
    }
}
