﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheaterHallController : ControllerBase
    {
        public TheaterHallController(ILogger<TheaterController> logger) { 
        }
    }
}
