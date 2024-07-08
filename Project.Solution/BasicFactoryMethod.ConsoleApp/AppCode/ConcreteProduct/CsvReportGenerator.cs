using BasicFactoryMethod.ConsoleApp.AppCode.Product;

namespace BasicFactoryMethod.ConsoleApp.AppCode.ConcreteProduct
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
