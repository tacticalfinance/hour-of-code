namespace design_patterns.Builder.contracts;

public interface ICar
{
    string Specification { get; }
    void SetBody(IBody body);
    void AttachWheel(IWheel wheel);
    void SetEngine(IEngine engine);
}