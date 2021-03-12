using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using System.IO;
using WebAPI.Helpers;

namespace WebAPI.Controllers
{
    [Route("api/Numbers")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        // POST: api/Numbers
        [HttpPost]
        public async Task<ActionResult<NumberContainer>> PostNumberContainer([FromBody] NumberContainer container)
        {
            NumberHelper.ExecuteContainerActions(container);
            return Ok(container.Numbers);
        }

        // GET: api/Numbers
        [HttpGet]
        public async Task<ActionResult<string>> GetNumberResults()
        {
            var resultText = NumberHelper.GetResultTextFromFile();
            return resultText;
        }
    }
}
