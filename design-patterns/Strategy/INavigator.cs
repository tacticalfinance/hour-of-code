namespace design_patterns.Strategy;

public interface INavigator
{
    IRoute Navigate(ICoordinate pointA, ICoordinate pointB);
}