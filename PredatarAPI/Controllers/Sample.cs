using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PredatarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredatarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sample : ControllerBase
    {
        [HttpGet]
        public ActionResult<ResponseModel> Get()
        {
            var response = new ResponseModel();
            response.ResponseMessage = "Welcome to Predatar!";
            return response;
        }
    }
}
