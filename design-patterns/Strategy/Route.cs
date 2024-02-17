namespace design_patterns.Strategy;

public class Route : IRoute
{
    private readonly IList<ICoordinate> coordinates = new List<ICoordinate>();

    public ICoordinate[] Coordinates => coordinates.ToArray();

    public void AddCoordinate(ICoordinate coordinate)
    {
        coordinates.Add(coordinate);
    }
}