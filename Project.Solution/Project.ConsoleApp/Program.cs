using Project.ConsoleApp.AppCode;

ReportGeneratorFactory ReportGeneratorFactory = new();

IReportGenerator xmlReportGenerator = ReportGeneratorFactory.GetReportGenerator(ReportGeneratorTypes.XML);
string xmlGenerateResult = xmlReportGenerator.GenerateReport();
Console.WriteLine(xmlGenerateResult);

IReportGenerator csvReportGenerator = ReportGeneratorFactory.GetReportGenerator(ReportGeneratorTypes.CSV);
string csvGenerateResult = csvReportGenerator.GenerateReport();
Console.WriteLine(csvGenerateResult);

Console.ReadKey();