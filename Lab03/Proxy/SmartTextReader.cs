using System;
using System.IO;

namespace Proxy
{
    public class SmartTextReader : IReader
    {
        private char[][] _textArray;

        public char[][] ReadTextFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                char[][] textArray = new char[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    int lineLength = lines[i].Length;
                    textArray[i] = new char[lineLength];

                    for (int j = 0; j < lineLength; j++)
                    {
                        textArray[i][j] = lines[i][j];
                    }
                }
                _textArray = textArray;
                return textArray;
            }
            else
            {
                throw new FileNotFoundException($"File '{filePath}' not found.");
            }
        }

        public char[][] GetCharArray()
        {
            return _textArray;
        }
        public void PrintTextArray()
        {
            if (_textArray != null)
            {
                foreach (var row in _textArray)
                {
                    Console.WriteLine(new string(row)); 
                }
            }
            else
            {
                Console.WriteLine("Text array is empty or not initialized.");
            }
        }
    }
}