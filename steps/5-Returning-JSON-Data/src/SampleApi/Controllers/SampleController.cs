﻿using Microsoft.AspNetCore.Mvc;
using SampleApi.OutputModels;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : Controller
    {
        [Route("")]
        public IActionResult Hello()
        {
            var model = new HelloOutputModel();
            return Ok(model);
        }
    }
}
