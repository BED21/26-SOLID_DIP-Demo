
public class DataExporter
{
    public void ExportDataFromFile()
    {
        ILogger fLogger = new FileLogger();
        ILogger dbLogger = new DbLogger();

        try
        {
            // code to export data from files to database
            var result = new ErrorThrower(new IOException("Vi kastar ett IO-fel"));
            //var result = new ErrorThrower(new ArithmeticException("Vi kastar ett Aritmetik-fel"));
        }
        catch (IOException ex)
        {
            var logger = new ExceptionLogger(dbLogger);
            logger.LogException(ex);
        }
        catch (Exception ex)
        {
            new ExceptionLogger(fLogger).LogException(ex);
        }
    }
}
