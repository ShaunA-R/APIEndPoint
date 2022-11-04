using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIEndPoint.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class InputController : ControllerBase
    {
        [HttpGet]
    [Route("Dinner/{dinner}")]

    public string WhatIAteForDinner(string dinner){
        return $"You ate {dinner} for dinner? That seems a little odd but nice.";
    }

    [HttpGet]
    [Route("Multiply/{userNum1}/{userNum2}")]

    public int MultiplyNumbers(int userNum1, int userNum2){
        return userNum1 * userNum2;
    }
    }
