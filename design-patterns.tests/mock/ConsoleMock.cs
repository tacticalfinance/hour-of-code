namespace design_patterns.tests.mock;

public class ConsoleMock : IDisposable
{
    private readonly StringWriter _mockOutput;
    private readonly TextWriter _originalOutput;

    public ConsoleMock()
    {
        _mockOutput = new StringWriter();
        _originalOutput = Console.Out;
        Console.SetOut(_mockOutput);
    }

    public string Output => _mockOutput.ToString();

    public void Dispose()
    {
        Console.SetOut(_originalOutput);
        _mockOutput.Dispose();
    }
}