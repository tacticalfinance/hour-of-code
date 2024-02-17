namespace design_patterns.Strategy;

public interface INavigator
{
    IRoute Navigate(NavigationType navigationType, ICoordinate pointA, ICoordinate pointB);
}