static double ToRadians(double degrees)
{
    return degrees * Math.PI / 180;
}

static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
{
    // Earth radius in kilo-meters
    const double earthRadius = 6371;

    // Convert degrees to radians
    double lat1Rad = ToRadians(lat1);
    double lon1Rad = ToRadians(lon1);
    double lat2Rad = ToRadians(lat2);
    double lon2Rad = ToRadians(lon2);

    // Calculate differences
    double dLat = lat2Rad - lat1Rad;
    double dLon = lon2Rad - lon1Rad;

    // Calculate Haversine formula
    double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
               Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
               Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
    double distance = earthRadius * c;

    return distance;
}

var distance = CalculateDistance(lat1: 9.1342F, lon1: 99.3334F, lat2: 13.7563F, lon2: 100.5018F);
// var distance = CalculateDistance(lat1: 13.7563F, lon1: 100.5018F, lat2: 9.1342F, lon2: 99.3334F);
Console.WriteLine($"Distance: {distance}");