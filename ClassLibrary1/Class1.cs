using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1 : RealProxy
    {
        public override IMessage Invoke(IMessage msg)
        {
            throw new NotImplementedException();
        }
    }
}
