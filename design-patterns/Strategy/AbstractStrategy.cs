namespace design_patterns.Strategy;

public abstract class AbstractStrategy : INavigationStrategy
{
    protected abstract NavigationType NavigationType { get; }
    protected abstract int Divider { get; }

    public IRoute BuildRoute(ICoordinate pointA, ICoordinate pointB)
    {
        IRoute route = new Route(NavigationType);
        var longitudeStep = (pointB.Longitude - pointA.Longitude) / Divider;
        var latitudeStep = (pointB.Latitude - pointA.Latitude) / Divider;
        Enumerable
            .Range(0, Divider + 1)
            .Select(i =>
                new Coordinate(pointA.Latitude + i * latitudeStep, pointA.Longitude + i * longitudeStep))
            .ToList()
            .ForEach(c => route.AddCoordinate(c));
        return route;
    }
}