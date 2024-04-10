using design_patterns.FactoryMethod;
using design_patterns.FactoryMethod.contracts;
using Xunit;

namespace design_patterns.tests;

public class FactoryMethodTests
{
    [Fact]
    public void TestFactoryMethodSolution()
    {
        IDocumentFactory documentFactory = new WordDocumentFactory();
        Assert.IsAssignableFrom<IDocument>(documentFactory.LoadDocument("a.doc"));
        Assert.IsType<WordDocument>(documentFactory.LoadDocument("a.doc"));
        ArgumentException exception = Assert.Throws<ArgumentException>(() => documentFactory.LoadDocument("a.doc2"));
        Assert.Equal("This factory can handle only .doc files; unsupported file type .doc2", exception.Message);

        documentFactory = new ExcelDocumentFactory();
        Assert.IsAssignableFrom<IDocument>(documentFactory.LoadDocument("b.xls"));
        Assert.IsType<ExcelDocument>(documentFactory.LoadDocument("b.xls"));
        exception = Assert.Throws<ArgumentException>(() => documentFactory.LoadDocument("b.xls2"));
        Assert.Equal("This factory can handle only .xls files; unsupported file type .xls2", exception.Message);

        documentFactory = new PdfDocumentFactory();
        Assert.IsAssignableFrom<IDocument>(documentFactory.LoadDocument("c.pdf"));
        Assert.IsType<PdfDocument>(documentFactory.LoadDocument("c.pdf"));
        exception = Assert.Throws<ArgumentException>(() => documentFactory.LoadDocument("c.pdf2"));
        Assert.Equal("This factory can handle only .pdf files; unsupported file type .pdf2", exception.Message);
    }
}