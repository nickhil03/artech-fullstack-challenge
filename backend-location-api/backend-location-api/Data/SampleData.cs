using backend_location_api.Models;

namespace backend_location_api.Data
{
    public static class SampleData
    {
        public static List<Location> Locations { get; } =
        [
            new() { Name = "Care Pharmacy", Type = "Pharmacy", OpenTime = new(9, 0), CloseTime = new(13, 0) },
            new() { Name = "Sweet Treats Bakery", Type = "Bakery", OpenTime = new(8, 0), CloseTime = new(11, 0) },
            new() { Name = "D Mart", Type = "Supermarket", OpenTime = new(10, 0), CloseTime = new(18, 0) },
            new() { Name = "Glitz Barber", Type = "Barber Shop", OpenTime = new(12, 0), CloseTime = new(17, 0) },
            new() { Name = "Candy Crush Store", Type = "Candy", OpenTime = new(10, 30), CloseTime = new(13, 30) },
            new() { Name = "Shopprix Mall", Type = "Cinema", OpenTime = new(11, 0), CloseTime = new(23, 0) },
            new() { Name = "Green Get", Type = "Grocery", OpenTime = new(7, 0), CloseTime = new(11, 0) },
            new() { Name = "FitnessPro Gym", Type = "Gym", OpenTime = new(6, 0), CloseTime = new(22, 0) },
            new() { Name = "R. Laal Book Deport", Type = "Bookstore", OpenTime = new(10, 0), CloseTime = new(14, 0) },
            new() { Name = "Dr Lal Pathlabs", Type = "Health", OpenTime = new(9, 0), CloseTime = new(13, 0) }
        ];
    }
}
