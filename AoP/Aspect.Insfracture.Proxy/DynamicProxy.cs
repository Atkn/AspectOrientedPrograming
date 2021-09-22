using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Aspect.Insfracture.Proxy
{
    public class DynamicProxy<TEntity> : RealProxy
    {
        private readonly TEntity _decorated;
        public DynamicProxy(TEntity decorated) : base(typeof(TEntity))
        {
            _decorated = decorated;
        }

        
        private void Log(string msg, object arg = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }

        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = msg as IMethodCallMessage;
            var methodInfo = methodCall.MethodBase as MethodInfo;
            Log("In dynamic proxy - before executing '{0}'", methodCall.MethodName);
            try
            {
                var result = methodInfo.Invoke(_decorated, methodCall.InArgs);
                Log("In Dynamic Proxy - After executing '{0}'", methodCall.MethodName);
                return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);

            }
            catch (Exception exception)
            {

                Log(string.Format("In Dynamic Proxy - Exception {0} executing '{1}'", exception, methodCall.MethodName));
                return new ReturnMessage(exception, methodCall);
            }
        }

    }
}
