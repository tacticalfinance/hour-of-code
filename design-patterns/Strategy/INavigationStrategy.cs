namespace design_patterns.Strategy;

public interface INavigationStrategy
{
    IRoute BuildRoute(ICoordinate pointA, ICoordinate pointB);
}