using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace SevenShadow.Genie.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BaseController : Controller
    {
       
        protected readonly AppSettings _settings;

        public BaseController(IOptions<AppSettings> appSettings)
        {
            _settings = appSettings.Value;
        }
        

    }
}
