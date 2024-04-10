using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public abstract class AbstractDocumentFactory : IDocumentFactory
{
    protected abstract string FileExtension { get; }
    protected abstract IDocument CreateDocument();

    public IDocument LoadDocument(string filePath)
    {
        var extension = Path.GetExtension(filePath).ToLower();
        if (extension != FileExtension)
            throw new ArgumentException(
                $"This factory can handle only {FileExtension} files; unsupported file type {extension}");

        IDocument document = CreateDocument();
        document.Load(filePath);
        return document;
    }
}