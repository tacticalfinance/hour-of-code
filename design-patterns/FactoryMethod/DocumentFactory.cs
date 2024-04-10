using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class DocumentFactory : IDocumentFactory
{
    public IDocument LoadDocument(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLower();
        IDocument document = null!;
        switch (extension)
        {
            case ".doc":
                document = new WordDocument();
                break;
            case ".xls":
                document = new ExcelDocument();
                break;
            case ".pdf":
                document = new PdfDocument();
                break;
            default:
                throw new ArgumentException($"unsupported file type {extension}");
        }

        document.Load(filePath);
        return document;
    }
}