using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace Spring.AOP.ConsoleTest
{
    [Serializable]
    //[ProfilerAspect(AttributeExclude = true)]
    public class ProfilerAspect : PostSharp.Aspects.OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {            
            args.MethodExecutionTag = Stopwatch.StartNew();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Stopwatch sw = (Stopwatch)args.MethodExecutionTag;
            sw.Stop();

            string output = string.Format("{0} Executed in {1} seconds",
                                args.Method.Name, sw.ElapsedMilliseconds / 1000);

            System.Diagnostics.Debug.WriteLine(output);
        }
    }
}
