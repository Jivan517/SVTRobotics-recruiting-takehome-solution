using Microsoft.AspNetCore.Mvc;
using SvtRoboticsLoaderApi.Models;
using SvtRoboticsLoaderApi.Processors.Interfaces;

namespace SvtRoboticsLoaderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobotsController : ControllerBase
    {
        private readonly ILoadProcessor _loadProcessor;
        private readonly ILogger<RobotsController> _logger;

        public RobotsController(ILoadProcessor loadProcessor, ILogger<RobotsController> logger)
        {
            _loadProcessor = loadProcessor;
            _logger = logger;
        }

        [HttpPost]
        [Route("closest")]
        [ProducesResponseType(typeof(LoaderOutput), StatusCodes.Status200OK)]
        public async Task<IActionResult> FindClosestAsync([FromBody] Load load)
        {
            try
            {
                var output = await _loadProcessor.GetClosestAsync(load);
                return Ok(output);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred", ex);
                return StatusCode(500, ex.Message);
            }
        }

    }
}
