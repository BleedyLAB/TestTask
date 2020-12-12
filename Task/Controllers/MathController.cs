using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Task.Interfaces;
using Task.Util;

namespace Task.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {

        private readonly ILogger<MathController> _logger;

        private IMath<double> _math;


        public MathController(ILogger<MathController> Logger, IMath<double> Math)
        {
            _logger = Logger;
            _math = Math;

        }

        [HttpGet("/")]
        public string GetInfo()
        {
            return "Simple  calculator for calculates  median, mode, variance and standard deviation";
        }

        [HttpPost("/math")]
        public Dictionary<String, string> SendMath([FromBody] DataImpl Data)
        {
            Dictionary<String, string> ResultMap = new Dictionary<string, string>();

            ResultMap.Add("Медиана", _math.GetMediana(Data.GetList(), Data.GetDigits()).ToString());
            ResultMap.Add("Мода", String.Join("; ", _math.GetModa(Data.GetList(), Data.GetDigits())));
            ResultMap.Add("СКО", _math.GetMSD(Data.GetList(), Data.GetDigits()).ToString());
            ResultMap.Add("Дисперсия", _math.GetDispersion(Data.GetList(), Data.GetDigits()).ToString());

            return ResultMap;

        }
    }
}
