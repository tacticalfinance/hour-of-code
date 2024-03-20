namespace design_patterns.Builder;

public class HatchbackCarBuilder : AbstractCarBuilder
{
    public override void BuildBody()
    {
        Car.SetBody(new Body("Hatchback"));
    }

    public override void BuildEngine()
    {
        Car.SetEngine(new Engine(85));
    }

    public override void BuildWheel()
    {
        Car.AttachWheel(new Wheel(16));
    }
}