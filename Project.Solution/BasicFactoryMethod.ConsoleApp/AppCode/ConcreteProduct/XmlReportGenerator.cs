using BasicFactoryMethod.ConsoleApp.AppCode.Product;

namespace BasicFactoryMethod.ConsoleApp.AppCode.ConcreteProduct
{
    // 2. Concrete Product.
    public class XmlReportGenerator : IReportGenerator
    {
        public string GenerateReport()
        {
            return "This is an generated XML Report.";
        }
    }
}
