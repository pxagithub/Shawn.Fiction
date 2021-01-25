using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shawn.Fiction.Application.HelloWorld;
using Volo.Abp.AspNetCore.Mvc;

namespace Shawn.Fiction.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : AbpController
    {
        private readonly IHelloWorldService _helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            _helloWorldService = helloWorldService;
        }

        [HttpGet]
        public string HelloWorld()
        {
            return _helloWorldService.HelloWorld();
        }
    }
}
