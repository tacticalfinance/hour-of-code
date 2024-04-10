namespace design_patterns.FactoryMethod;

public class PdfDocumentFactory : AbstractDocumentFactory<PdfDocument>
{
    protected override string FileExtension => ".pdf";
}