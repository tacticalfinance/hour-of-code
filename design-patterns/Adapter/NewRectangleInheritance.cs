namespace design_patterns.Adapter;

public class NewRectangleInheritance(
    int topLeftX,
    int topLeftY,
    int topRightX,
    int topRightY,
    int bottomRightX,
    int bottomRightY,
    int bottomLeftX,
    int bottomLeftY) :
    OriginalRectangle(topLeftX,
        topLeftY,
        topRightX,
        topRightY,
        bottomRightX,
        bottomRightY,
        bottomLeftX,
        bottomLeftY), INewRectangle
{
    public IPoint TopLeftPoint => new Point(TopLeftX, TopLeftY);
    public int Width => TopRightX - TopLeftX;
    public int Height => TopLeftY - BottomLeftY;
}