using BasicFactoryMethod.ConsoleApp.AppCode.Enums;
using BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.AbstractProduct;
using BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.ConcreteProduct;

namespace BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.Factory
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
