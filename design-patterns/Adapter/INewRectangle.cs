namespace design_patterns.Adapter;

public interface INewRectangle
{
    IPoint TopLeftPoint { get; }
    int Width { get; }
    int Height { get; }
}