using BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.AbstractProduct;

namespace BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.ConcreteProduct
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
