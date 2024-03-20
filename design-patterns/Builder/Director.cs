using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public class Director : IDirector
{
    public ICarBuilder Builder { private get; set; } = null!;

    public void BuildCar()
    {
        Builder.StartNewCar();
        Builder.BuildBody();
        Builder.BuildEngine();
        for (var i = 0; i < 4; i++) Builder.BuildWheel();
    }
}