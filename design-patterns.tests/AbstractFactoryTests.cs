using design_patterns.AbstractFactory;
using design_patterns.AbstractFactory.contracts;
using design_patterns.tests.mock;
using Xunit;

namespace design_patterns.tests;

public class AbstractFactoryTests
{
    private string Newline => "\r\n";

    [Fact]
    public void TestLightTheme()
    {
        IGuiFactory guiFactory = new GuiFactory();
        IButton button = guiFactory.CreateButton("Light");
        ITextBox textBox = guiFactory.CreateTextBox("Light");
        
        Assert.IsType<LightButton>(button);
        Assert.IsType<LightTextBox>(textBox);

        using var console = new ConsoleMock();
        button.Render();
        textBox.Render();
        Assert.Equal($"Light Button{Newline}Light TextBox{Newline}", console.Output);
    }

    [Fact]
    public void TestDarkTheme()
    {
        IGuiFactory guiFactory = new GuiFactory();
        IButton button = guiFactory.CreateButton("Dark");
        ITextBox textBox = guiFactory.CreateTextBox("Dark");

        Assert.IsType<DarkButton>(button);
        Assert.IsType<DarkTextBox>(textBox);

        using var console = new ConsoleMock();
        button.Render();
        textBox.Render();
        Assert.Equal($"Dark Button{Newline}Dark TextBox{Newline}", console.Output);
    }

    [Fact]
    public void TestNonExistingTheme()
    {
        IGuiFactory guiFactory = new GuiFactory();

        ArgumentException exception =
            Assert.Throws<ArgumentException>(() => guiFactory.CreateButton("NonExistingTheme"));
        Assert.Equal("Can't create Button for theme NonExistingTheme", exception.Message);

        exception = Assert.Throws<ArgumentException>(() => guiFactory.CreateTextBox("NonExistingTheme"));
        Assert.Equal("Can't create TextBox for theme NonExistingTheme", exception.Message);
    }
}