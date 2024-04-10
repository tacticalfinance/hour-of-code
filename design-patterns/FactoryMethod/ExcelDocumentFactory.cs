using design_patterns.FactoryMethod.contracts;

namespace design_patterns.FactoryMethod;

public class ExcelDocumentFactory : AbstractDocumentFactory
{
    protected override string FileExtension => ".xls";

    protected override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}