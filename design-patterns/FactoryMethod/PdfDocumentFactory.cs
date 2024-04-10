using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class PdfDocumentFactory : IDocumentFactory
{
    public IDocument LoadDocument(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLower();
        if (extension != ".pdf")
            throw new ArgumentException(
                $"This factory can handle only .pdf files; unsupported file type {extension}");

        IDocument document = new PdfDocument();
        document.Load(filePath);
        return document;
    }
}