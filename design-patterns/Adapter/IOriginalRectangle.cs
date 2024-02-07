namespace design_patterns.Adapter;

public interface IOriginalRectangle
{
    int TopLeftX { get; }
    int TopLeftY { get; }
    int TopRightX { get; }
    int TopRightY { get; }
    int BottomRightX { get; }
    int BottomRightY { get; }
    int BottomLeftX { get; }
    int BottomLeftY { get; }
}