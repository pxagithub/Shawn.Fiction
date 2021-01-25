using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shawn.Fiction;


namespace Shawn.Fiction.Application.HelloWorld.Impl
{
    public class HelloWorldService : ServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
