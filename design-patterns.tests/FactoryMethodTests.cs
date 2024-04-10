using design_patterns.FactoryMethod;
using design_patterns.FactoryMethod.contracts;
using Xunit;

namespace design_patterns.tests;

public class FactoryMethodTests
{
    [Fact]
    public void TestTrivialSolution()
    {
        IDocumentFactory documentFactory = new DocumentFactory();

        Assert.IsAssignableFrom<IDocument>(documentFactory.LoadDocument("a.doc"));
        Assert.IsAssignableFrom<IDocument>(documentFactory.LoadDocument("b.xls"));
        Assert.IsAssignableFrom<IDocument>(documentFactory.LoadDocument("c.pdf"));

        Assert.IsType<WordDocument>(documentFactory.LoadDocument("a.doc"));
        Assert.IsType<ExcelDocument>(documentFactory.LoadDocument("b.xls"));
        Assert.IsType<PdfDocument>(documentFactory.LoadDocument("c.pdf"));

        ArgumentException exception = Assert.Throws<ArgumentException>(() => documentFactory.LoadDocument("a.ppt"));
        Assert.Equal("unsupported file type .ppt", exception.Message);
    }
}