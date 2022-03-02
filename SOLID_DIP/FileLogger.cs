public class FileLogger : ILogger
{
    public void LogMessage(string aStackTrace)
    {
        //code to log stack trace into a file.  
        Console.WriteLine($"I FileLogger. Felmeddelande: {aStackTrace}");
    }
}