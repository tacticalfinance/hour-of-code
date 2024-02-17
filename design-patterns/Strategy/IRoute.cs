namespace design_patterns.Strategy;

public interface IRoute
{
    ICoordinate[] Coordinates { get; }
    void AddCoordinate(ICoordinate coordinate);
}