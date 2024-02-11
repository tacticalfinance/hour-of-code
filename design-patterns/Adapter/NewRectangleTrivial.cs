namespace design_patterns.Adapter;

public class NewRectangleTrivial(IPoint topLeftPoint, int width, int height) : INewRectangle
{
    public IPoint TopLeftPoint { get; } = topLeftPoint;
    public int Width { get; } = width;
    public int Height { get; } = height;
}