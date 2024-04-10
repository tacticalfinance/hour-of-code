using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class ExcelDocumentFactory : IDocumentFactory
{
    public IDocument LoadDocument(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLower();
        if (extension != ".xls")
            throw new ArgumentException(
                $"This factory can handle only .xls files; unsupported file type {extension}");

        IDocument document = new ExcelDocument();
        document.Load(filePath);
        return document;
    }
}