namespace design_patterns.Strategy;

public class Navigator : INavigator
{
    public IRoute Navigate(ICoordinate pointA, ICoordinate pointB)
    {
        return NavigationStrategy.BuildRoute(pointA, pointB);
    }

    public INavigationStrategy NavigationStrategy { private get; set; } = null!;
}