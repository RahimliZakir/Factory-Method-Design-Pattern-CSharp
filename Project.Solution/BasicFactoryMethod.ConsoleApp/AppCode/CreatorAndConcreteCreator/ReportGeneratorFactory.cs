using BasicFactoryMethod.ConsoleApp.AppCode.ConcreteProduct;
using BasicFactoryMethod.ConsoleApp.AppCode.Enums;
using BasicFactoryMethod.ConsoleApp.AppCode.Product;

namespace BasicFactoryMethod.ConsoleApp.AppCode.CreatorAndConcreteCreator
{
    // 3. Creator.
    public class ReportGeneratorFactory
    {
        public IReportGenerator GetReportGenerator(ReportGeneratorTypes format)
        {
            // 4. Concrete Creator.
            return format switch
            {
                ReportGeneratorTypes.XML => new XmlReportGenerator(),
                ReportGeneratorTypes.CSV => new CsvReportGenerator(),
                _ => throw new ApplicationException("Report format not supported."),
            };
        }
    }
}
