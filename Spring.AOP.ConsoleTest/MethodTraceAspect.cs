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
    public class MethodTraceAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            //args.MethodExecutionTag = Stopwatch.StartNew();
            return;
        }

        //public override void OnExit(MethodExecutionArgs args)
        //{
        //    Stopwatch sw = (Stopwatch)args.MethodExecutionTag;
        //    sw.Stop();            
        //}
    }
}
