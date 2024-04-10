using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class PdfDocumentFactory : AbstractDocumentFactory
{
    protected override string FileExtension => ".pdf";

    protected override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}