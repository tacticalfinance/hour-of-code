namespace design_patterns.Strategy;

public class FlyingStrategy : INavigationStrategy
{
    public IRoute BuildRoute(ICoordinate pointA, ICoordinate pointB)
    {
        IRoute route = new Route(NavigationType.Flying);
        route.AddCoordinate(pointA);
        route.AddCoordinate(pointB);
        return route;
    }
}