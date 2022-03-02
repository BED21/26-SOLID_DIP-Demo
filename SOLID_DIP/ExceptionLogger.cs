

public class ExceptionLogger
{
    private readonly ILogger _logger;

    public ExceptionLogger(ILogger logger)
    {
        _logger = logger;
    }

    public void LogException(Exception exception)
    {
        string message = GetUserReadableMessage(exception);
        _logger.LogMessage(message);
    }

    private static string GetUserReadableMessage(Exception ex)
    {
        string strMessage = string.Empty;
        //code to convert Exception's stack trace and message to user readable format.  
        strMessage = ex.Message;
        return strMessage;
    }
}