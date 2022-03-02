public static class ExceptionLogger
{
    public static void LogIntoFile(Exception aException)
    {
        FileLogger objFileLogger = new FileLogger();
        objFileLogger.LogMessage(GetUserReadableMessage(aException));
    }
    private static string GetUserReadableMessage(Exception ex)
    {
        string strMessage = string.Empty;
        //code to convert Exception's stack trace and message to user readable format.  
        return strMessage;
    }
}