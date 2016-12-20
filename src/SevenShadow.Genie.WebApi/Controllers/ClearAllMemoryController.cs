using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace SevenShadow.Genie.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ClearAllMemoryController : BaseController
    {

        public ClearAllMemoryController(IOptions<AppSettings> appSettings) : base(appSettings) {}
        
        [HttpGet]
        public async Task<JObject> Get()
        {
            GenieHelper helper = new GenieHelper(_settings.GenieBottleUrl);
            return await helper.ClearAllMemory();
        }

    }
}
