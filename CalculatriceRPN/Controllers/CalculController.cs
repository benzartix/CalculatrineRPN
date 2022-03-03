using CalculatriceRPN.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceRPN.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculController : ControllerBase
    {
        private readonly ICalculService _calculService;
        private readonly ILogger<CalculController> _logger;

        public CalculController(ILogger<CalculController> logger , ICalculService calculService)
        {
            _logger = logger;
            _calculService = calculService;
        }





        [HttpGet]
        public IActionResult Get([FromQuery] string[] ArrayInput)
        {
            try
            {
                if(ArrayInput.Count() != 0)
                {
                    Stack<string> result = _calculService.Operation(ArrayInput);
                    return Ok(result);
                }
                else
                {
                    return BadRequest(new { ErrorMessage = "La liste des valeur est vide" });
                }

            }
            catch (Exception exp)
            { return BadRequest(new { ErrorMessage = exp.Message }); }

        }
    }

}
