using BasicFactoryMethod.ConsoleApp.AppCode.CreatorAndConcreteCreator;
using BasicFactoryMethod.ConsoleApp.AppCode.Enums;
using BasicFactoryMethod.ConsoleApp.AppCode.Product;

ReportGeneratorFactory reportGeneratorFactory = new();

IReportGenerator xmlReportGenerator = reportGeneratorFactory.GetReportGenerator(ReportGeneratorTypes.XML);
string xmlGenerateResult = xmlReportGenerator.GenerateReport();
Console.WriteLine(xmlGenerateResult);

IReportGenerator csvReportGenerator = reportGeneratorFactory.GetReportGenerator(ReportGeneratorTypes.CSV);
string csvGenerateResult = csvReportGenerator.GenerateReport();
Console.WriteLine(csvGenerateResult);

Console.ReadKey();