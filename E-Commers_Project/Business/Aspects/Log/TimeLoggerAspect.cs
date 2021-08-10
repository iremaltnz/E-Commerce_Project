using Business.Utilities.Interceptors;
using Castle.DynamicProxy;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Business.Aspects.Perfomance
{
    class TimeLoggerAspect: MethodInterception
    {
       
        private Stopwatch _stopWatch;
       
        public TimeLoggerAspect()
        { 
            _stopWatch = new Stopwatch();
      
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _stopWatch.Start();

        }

        protected override void OnAfter(IInvocation invocation)
        {
            _stopWatch.Stop();


            string logPath = ConfigurationManager.AppSettings["logPath"];

            using (StreamWriter writer=new StreamWriter(logPath,true))
            {
                writer.WriteLine($"Metot İsmi : {invocation.Method.Name}");
                writer.WriteLine($"Çalışma Süresi : {_stopWatch.Elapsed.TotalSeconds} sn");
                writer.WriteLine($"Loglama Tarihi : {DateTime.Now}");
                writer.WriteLine();
            }
           

        }

    }
}
