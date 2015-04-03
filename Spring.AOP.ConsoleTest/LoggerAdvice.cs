using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;

namespace Spring.AOP.ConsoleTest
{
    public class LoggerAdvice : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            if (false)
            {
                // Logging BEFORE method invocation
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("Begin method call: " + invocation.Method.Name);

                // Log the passed arguments.
                if (invocation.Arguments != null)
                    foreach (object arg in invocation.Arguments)
                        Console.WriteLine(("Argument: " + arg.ToString()).PadLeft(15));


                Console.WriteLine(string.Empty);

                // Invoke the called method
                object methodReturn = invocation.Proceed();

                Console.WriteLine(string.Empty);

                // Logging AFTER method invocation
                Console.WriteLine("End method call: " + invocation.Method.Name);
                Console.WriteLine("--------------------");

                // Return the value of the method
                return methodReturn;
            }
            else
            {
                // Invoke the called method
                return invocation.Proceed();
            }



        }
    }
}
