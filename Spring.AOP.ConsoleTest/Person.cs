using System;

namespace Spring.AOP.ConsoleTest
{
    public class PersonNoAOP : IPerson
    {
        public void SayHello()
        {
            Logger.WriteBegin("SayHello"); // logging

            Console.WriteLine("Hello!");

            Logger.WriteEnd("SayHello"); // logging
        }

        public string GetAddress()
        {
            string retVal;
            Logger.WriteBegin("GetAddress"); // loggin

            retVal = "Route 66";

            Logger.WriteEnd("GetAddress"); // loggin... again
            return retVal;
        }

        public int DoSomething(int num, int num2)
        {
            int calc;
            Logger.WriteBegin("DoSomething"); // logging

            calc = num + num2;

            Logger.WriteEnd("DoSomething"); // logging
            return calc;
        }
    }

    public class Person : IPerson
    {
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
