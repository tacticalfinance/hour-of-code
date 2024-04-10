using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class WordDocumentFactory : AbstractDocumentFactory
{
    protected override string FileExtension => ".doc";

    protected override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}