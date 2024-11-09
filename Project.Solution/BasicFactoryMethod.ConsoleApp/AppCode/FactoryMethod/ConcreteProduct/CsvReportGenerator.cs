using BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.AbstractProduct;

namespace BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.ConcreteProduct
{
    // 2. Concrete Product.
    public class CsvReportGenerator : IReportGenerator
    {
        public string GenerateReport()
        {
            return "This is an generated CSV Report.";
        }
    }
}
