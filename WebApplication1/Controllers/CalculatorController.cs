using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "get";
        }

        public void Add()
        {
           
        }

        public void Subtract()
        {
        
        }

        public void Mutlipy()
        {

        }

        public void Divide()
        {

        }
    }
}
