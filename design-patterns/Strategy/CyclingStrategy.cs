namespace design_patterns.Strategy;

public class CyclingStrategy : INavigationStrategy
{
    public IRoute BuildRoute(ICoordinate pointA, ICoordinate pointB)
    {
        IRoute route = new Route(NavigationType.Cycling);
        double longitudeStep = (pointB.Longitude - pointA.Longitude) / 4;
        double latitudeStep = (pointB.Latitude - pointA.Latitude) / 4;
        Enumerable.Range(0, 5)
            .Select(i =>
                new Coordinate(pointA.Latitude + i * latitudeStep, pointA.Longitude + i * longitudeStep))
            .ToList().ForEach(c => route.AddCoordinate(c));
        return route;
    }
}