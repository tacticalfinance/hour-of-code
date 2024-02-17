namespace design_patterns.Strategy;

public class Navigator : INavigator
{
    public IRoute Navigate(ICoordinate pointA, ICoordinate pointB)
    {
        IRoute route = new Route();
        route.AddCoordinate(pointA);
        route.AddCoordinate(pointB);
        return route;
    }
}