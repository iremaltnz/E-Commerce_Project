using Business.Utilities.Interceptors;
using Castle.DynamicProxy;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Aspects.Cache
{
   public class CacheAspect: MethodInterception
    {
        private int duration;
        IMemoryCache _memoryCache;

        

        public CacheAspect()
        {

            _memoryCache = ServiceTool.ServiceProvider.GetService<IMemoryCache>();
            duration = 60;
        }


        public override void Intercept(IInvocation invocation)
        {
            var methodName = invocation.Method.Name.ToString();
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
            Console.WriteLine(key);

            if (_memoryCache.TryGetValue(key, out _))
            {
                invocation.ReturnValue = _memoryCache.Get(key);
                return;
            }

            invocation.Proceed();
            _memoryCache.Set(key, invocation.ReturnValue, TimeSpan.FromMinutes(duration));

        }
    }

    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
