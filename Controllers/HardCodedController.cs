using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIEndPoint.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class HardCodedController : ControllerBase
    {
        [HttpGet]
        [Route("Dinner")]

    public string WhatIAteForDinner()
    {
        return "I ate some chili beans and cornbread.";
    }

    [HttpGet]
    [Route("Multiply")]

    public int MultiplyNumbers(){
        return 2 * 2;
    }
    }
