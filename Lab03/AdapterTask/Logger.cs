namespace Adapter;

public class Logger : ILogger
{
    public void Log(string msg)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(msg);
        Console.ResetColor();
    }
    public void Error(string msg)
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(msg);
        Console.ResetColor();

    }
    public void Warn(string msg)
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(msg);
        Console.ResetColor();

    }
}