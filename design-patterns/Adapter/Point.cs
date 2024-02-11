namespace design_patterns.Adapter;

public class Point(int xCor, int yCor) : IPoint
{
    public int XCor { get; } = xCor;
    public int YCor { get; } = yCor;
}