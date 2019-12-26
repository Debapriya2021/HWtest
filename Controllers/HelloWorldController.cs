using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HWTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        //private static readonly string hello = "hello-world";


        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var obj = new Word();
        //    obj.word = hello;
        //    return new OkObjectResult(obj);
        //}

        [HttpGet]

        public string Get()
        {
            var word = "Hello-World";
            return word;
        }

    }
}