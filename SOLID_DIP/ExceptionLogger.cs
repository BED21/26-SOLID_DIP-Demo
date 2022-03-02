

public static class ExceptionLogger
{
    public static void LogIntoFile(Exception aException)
    {
        FileLogger objFileLogger = new FileLogger();
        objFileLogger.LogMessage(GetUserReadableMessage(aException));
    }
    public static void LogIntoDatabase(Exception aException)
    {
        DbLogger objDbLogger = new DbLogger();
        objDbLogger.LogMessage(GetUserReadableMessage(aException));
    }

    private static string GetUserReadableMessage(Exception ex)
    {
        string strMessage = string.Empty;
        //code to convert Exception's stack trace and message to user readable format.  
        strMessage = ex.Message;
        return strMessage;
    }
}