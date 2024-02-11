namespace design_patterns.Adapter;

public class OldToNewRectangleAdapter(IOriginalRectangle adaptee) : INewRectangle
{
    private IOriginalRectangle Adaptee { get; } = adaptee;

    public IPoint TopLeftPoint => new Point(Adaptee.TopLeftX, Adaptee.TopLeftY);
    public int Width => Adaptee.TopRightX - Adaptee.TopLeftX;
    public int Height => Adaptee.TopLeftY - Adaptee.BottomLeftY;
}