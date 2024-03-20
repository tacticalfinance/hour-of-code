using design_patterns.Builder.contracts;

namespace design_patterns.Builder;

public class Car : ICar
{
    private readonly List<IWheel> _wheels = new();
    private IBody _body = null!;
    private IEngine _engine = null!;

    public void SetBody(IBody body)
    {
        _body = body;
    }

    public void AttachWheel(IWheel wheel)
    {
        _wheels.Add(wheel);
    }

    public void SetEngine(IEngine engine)
    {
        _engine = engine;
    }

    public string Specification =>
        $"body: {_body.Shape}\n" +
        $"engine horsepower: {_engine.Horsepower}\n" +
        $"number of wheels: {_wheels.Count}\n" +
        $"wheel size: {_wheels[0].Size}\"";
}