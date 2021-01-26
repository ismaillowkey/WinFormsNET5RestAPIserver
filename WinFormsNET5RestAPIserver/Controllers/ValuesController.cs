using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinFormsNET5RestAPIserver.Models;

namespace WinFormsNET5RestAPIserver.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController
    {
        public ValuesController()
        {

        }

        [HttpGet]
        // GET api/value
        public IActionResult Get()
        {
            var result = new RandomValue
            {
                DateNow = DateTime.Now,
                RandomInt = Convert.ToInt32(new Random().NextDouble() * 100)
            };
            return new JsonResult(result);
        }
    }
}
