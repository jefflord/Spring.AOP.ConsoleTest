using System;
using System.Collections.Generic;
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

                // create properties
                //NameValueCollection properties = new NameValueCollection();
                //properties["showDateTime"] = "true";

                // set Adapter
                //Common.Logging.LogManager.Adapter = new Common.Logging.Simple.TraceLoggerFactoryAdapter(properties);


                var appContext = ContextRegistry.GetContext();
                // Get the person object. "PersonAd" is defined in App.config.

                obj = (IPerson)appContext["PersonAd"];
            }
            

            obj.SayHello();
            Console.WriteLine(obj.GetAddress());
            Console.WriteLine(obj.DoSomething(33, 22).ToString());

        }
    }
}
