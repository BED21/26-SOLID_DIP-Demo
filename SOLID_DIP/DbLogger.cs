public class DbLogger : ILogger
{
    public void LogMessage(string aMessage)
    {
        //Code to write message in database.  
        Console.WriteLine($"I DbLogger. Felmeddelande: {aMessage}");
    }
}
