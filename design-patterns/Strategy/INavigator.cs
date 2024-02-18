namespace design_patterns.Strategy;

public interface INavigator
{
    INavigationStrategy NavigationStrategy { set; }
    IRoute Navigate(ICoordinate pointA, ICoordinate pointB);
}