static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(":");
        string new_word = logLine.Substring(index+1).Trim();
        return new_word;
       
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
       string[] new_word = logLine.Split(":");
        return new_word[0].ToLower().Trim('[',']');
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
       
        return $"{Message(logLine)} ({LogLevel(logLine)})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
