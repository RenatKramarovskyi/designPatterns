using System;
using System.IO;

namespace Proxy
{
    public class SmartTextChecker : IReader
    {
        private readonly IReader _textReader;
        private int _numberOfLines;
        private int _charactersPerLine;

        public SmartTextChecker(IReader concreteReader)
        {
            _textReader = concreteReader;
        }
        
        public char[][] ReadTextFromFile(string filePath)
        {
            char[][] charArray = _textReader.ReadTextFromFile(filePath);
            Console.WriteLine(new String('=', 25));
            if (charArray == null)
            {
                Console.WriteLine("There was a problem reading the file.");
            }
            else
            {
                Console.WriteLine("File was opened successfully");

                _numberOfLines = charArray.Length;

                _charactersPerLine = 0;
                foreach (var line in charArray)
                {
                    int lineLength = line.Length;
                    Console.WriteLine($"Characters in line: {lineLength}");
                    _charactersPerLine += lineLength;
                }

                Console.WriteLine($"Number of lines in the file: {_numberOfLines}");
                Console.WriteLine($"Maximum number of characters per line: {_charactersPerLine}");
            }

            Console.WriteLine("File was closed successfully");
            Console.WriteLine(new String('=', 25));
            return charArray;
        }

        public int GetNumberOfLines()
        {
            return _numberOfLines;
        }

        public int GetCharactersPerLine()
        {
            return _charactersPerLine;
        }
    }
}