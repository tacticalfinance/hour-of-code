namespace design_patterns.FactoryMethod;

public class ExcelDocumentFactory : AbstractDocumentFactory<ExcelDocument>
{
    protected override string FileExtension => ".xls";
}