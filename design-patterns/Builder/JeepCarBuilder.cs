namespace design_patterns.Builder;

public class JeepCarBuilder : AbstractCarBuilder
{
    public override void BuildBody()
    {
        Car.SetBody(new Body("Jeep"));
    }

    public override void BuildEngine()
    {
        Car.SetEngine(new Engine(400));
    }

    public override void BuildWheel()
    {
        Car.AttachWheel(new Wheel(22));
    }
}