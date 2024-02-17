namespace design_patterns.Strategy;

public interface IRoute
{
    NavigationType NavigationType { get; }
    ICoordinate[] Coordinates { get; }
    void AddCoordinate(ICoordinate coordinate);
}