namespace Project.ConsoleApp.AppCode
{
    public class ReportGeneratorFactory
    {
        public IReportGenerator GetReportGenerator(ReportGeneratorTypes format)
        {
            return format switch
            {
                ReportGeneratorTypes.XML => new XmlReportGenerator(),
                ReportGeneratorTypes.CSV => new CsvReportGenerator(),
                _ => throw new ApplicationException("Report format not supported."),
            };
        }
    }
}
