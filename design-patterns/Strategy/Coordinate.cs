namespace design_patterns.Strategy;

public class Coordinate(double latitude, double longitude) : ICoordinate
{
    public double Latitude { get; } = latitude;
    public double Longitude { get; } = longitude;
}