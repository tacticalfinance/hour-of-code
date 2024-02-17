namespace design_patterns.Strategy;

public class DrivingStrategy : INavigationStrategy
{
    public IRoute BuildRoute(ICoordinate pointA, ICoordinate pointB)
    {
        IRoute route = new Route(NavigationType.Driving);
        double longitudeStep = (pointB.Longitude - pointA.Longitude) / 2;
        double latitudeStep = (pointB.Latitude - pointA.Latitude) / 2;
        Enumerable.Range(0, 3)
            .Select(i =>
                new Coordinate(pointA.Latitude + i * latitudeStep, pointA.Longitude + i * longitudeStep))
            .ToList().ForEach(c => route.AddCoordinate(c));
        return route;
    }
}