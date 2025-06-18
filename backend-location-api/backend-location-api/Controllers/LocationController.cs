using backend_location_api.Data;
using backend_location_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend_location_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        [HttpGet("available-locations")]
        public ActionResult<IEnumerable<Location>> GetAvailableLocations(int startTime = 10, int endTime = 13)
        {
            var start = new TimeOnly(startTime, 0);
            var end = new TimeOnly(endTime, 0);

            var available = SampleData.Locations
                .Where(location => location.OpenTime <= start && location.CloseTime >= end)
                .ToList();

            if (available.Count == 0)
                return NotFound(new { message = "No locations available in this time window." });

            return Ok(available);
        }

        [HttpPost("add")]
        public ActionResult<Location> AddLocation(string name, string type, int startTime, int endTime)
        {
            if (SampleData.Locations.Any(location => location.Name != name))
            {
                var start = new TimeOnly(startTime, 0);
                var end = new TimeOnly(endTime, 0);
                Location location = new() { Name = name, Type = type, OpenTime = start, CloseTime = end };
                SampleData.Locations.Add(location);
                return Ok();
            }
            else
                return Conflict(new { message = "Locations already exists." });
        }
    }
}
