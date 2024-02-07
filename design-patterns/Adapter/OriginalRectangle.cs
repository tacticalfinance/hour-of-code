namespace design_patterns.Adapter;

public class OriginalRectangle(
    int topLeftX,
    int topLeftY,
    int topRightX,
    int topRightY,
    int bottomRightX,
    int bottomRightY,
    int bottomLeftX,
    int bottomLeftY) : IOriginalRectangle
{
    public int TopLeftX { get; } = topLeftX;
    public int TopLeftY { get; } = topLeftY;
    public int TopRightX { get; } = topRightX;
    public int TopRightY { get; } = topRightY;
    public int BottomRightX { get; } = bottomRightX;
    public int BottomRightY { get; } = bottomRightY;
    public int BottomLeftX { get; } = bottomLeftX;
    public int BottomLeftY { get; } = bottomLeftY;
}