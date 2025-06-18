namespace backend_location_api.Models
{
    public class Location
    {
        public required string Name { get; set; }
        public required string Type { get; set; }
        public TimeOnly OpenTime { get; set; }
        public TimeOnly CloseTime { get; set; }
    }
}
