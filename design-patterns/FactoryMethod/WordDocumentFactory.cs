using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class WordDocumentFactory : IDocumentFactory
{
    public IDocument LoadDocument(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLower();
        if (extension != ".doc")
            throw new ArgumentException(
                $"This factory can handle only .doc files; unsupported file type {extension}");

        IDocument document = new WordDocument();
        document.Load(filePath);
        return document;
    }
}