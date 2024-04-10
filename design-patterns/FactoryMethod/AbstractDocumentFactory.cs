using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public abstract class AbstractDocumentFactory<T> : IDocumentFactory where T : IDocument, new()
{
    protected abstract string FileExtension { get; }

    public IDocument LoadDocument(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLower();
        if (extension != FileExtension)
            throw new ArgumentException(
                $"This factory can handle only {FileExtension} files; unsupported file type {extension}");

        T document = new();
        document.Load(filePath);
        return document;
    }
}