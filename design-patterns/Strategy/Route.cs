namespace design_patterns.Strategy;

public class Route(NavigationType navigationType) : IRoute
{
    private readonly IList<ICoordinate> coordinates = new List<ICoordinate>();

    public NavigationType NavigationType { get; } = navigationType;
    public ICoordinate[] Coordinates => coordinates.ToArray();

    public void AddCoordinate(ICoordinate coordinate)
    {
        coordinates.Add(coordinate);
    }
}