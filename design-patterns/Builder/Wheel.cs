using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public class Wheel(int size) : IWheel
{
    public int Size { get; } = size;
}