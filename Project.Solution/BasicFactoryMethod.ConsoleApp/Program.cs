using BasicFactoryMethod.ConsoleApp.AppCode.Enums;
using BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.AbstractProduct;
using BasicFactoryMethod.ConsoleApp.AppCode.FactoryMethod.Factory;

ReportGeneratorFactory reportGeneratorFactory = new();

IReportGenerator xmlReportGenerator = reportGeneratorFactory.GetReportGenerator(ReportGeneratorTypes.XML);
string xmlGenerateResult = xmlReportGenerator.GenerateReport();
Console.WriteLine(xmlGenerateResult);

IReportGenerator csvReportGenerator = reportGeneratorFactory.GetReportGenerator(ReportGeneratorTypes.CSV);
string csvGenerateResult = csvReportGenerator.GenerateReport();
Console.WriteLine(csvGenerateResult);

Console.ReadKey();