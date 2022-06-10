using Microsoft.AspNetCore.Mvc;
using RobotProject.Services;
using System.Text.Json;

namespace RobotProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotSpottedController : ControllerBase
    {
        private readonly ILogger<RobotSpottedController> _logger;
        private readonly LocationService _service;



        // Inject LocationService into the constructor
        public RobotSpottedController(LocationService service, ILogger<RobotSpottedController> logger)
        {
            _service = service;
            _logger = logger;
            //_logger.LogCritical("Message created: Log critical message");
        }

        [HttpPost(Name = "RobotSpotted")]
        public async Task<string> Post(Location location)
        {
            //Can replace this with log critical
            _logger.Log(LogLevel.Information, new EventId(), null, "Logged:" + location.LocationName, null);


            string WaterSourceResponse = await _service.GetNearestBodyOfWater(location);


            JsonSerializer.Serialize(WaterSourceResponse);

            // DESERILISING
            WaterSourceLocation[] WaterSource = JsonSerializer.Deserialize<WaterSourceLocation[]>(WaterSourceResponse);
            return $"Send robot to: {location.LocationName} is {WaterSource[0].display_name}";

        }




    }
}