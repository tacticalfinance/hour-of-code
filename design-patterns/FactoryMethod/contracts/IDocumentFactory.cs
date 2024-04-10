namespace design_patterns.FactoryMethod.contracts;

public interface IDocumentFactory
{
    IDocument LoadDocument(string filePath);
}