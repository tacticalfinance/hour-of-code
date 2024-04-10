namespace design_patterns.FactoryMethod;

public class WordDocumentFactory : AbstractDocumentFactory<WordDocument>
{
    protected override string FileExtension => ".doc";
}