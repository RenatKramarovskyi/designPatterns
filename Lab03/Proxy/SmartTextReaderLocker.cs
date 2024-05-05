using System.Text.RegularExpressions;

namespace Proxy;

public class SmartTextReaderLocker : IReader
{   
    private readonly IReader _textReader;
    private readonly Regex _filePattern;

    public SmartTextReaderLocker(IReader concreteReader, string filePattern)
    {
        _textReader = concreteReader;
        _filePattern = new Regex(filePattern);
    }
    public char[][] ReadTextFromFile(string filePath)
    {
        Console.WriteLine(new String('=', 25));
        if (!_filePattern.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return null;
        }
        
        Console.WriteLine("Access allowed!");
        Console.WriteLine(new String('=', 25));
        
        return _textReader.ReadTextFromFile(filePath);
    }
}