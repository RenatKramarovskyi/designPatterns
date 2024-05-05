using System;
using System.IO;
using System.Runtime.InteropServices.JavaScript;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\renat.LAPTOP-65EIJ7OI\Documents\SECOND course\designPatterns\Lab03\Proxy\NewFile1.txt"; // access allowed (regex : @".*\.txt")
            // string filePath = @"C:\Users\renat.LAPTOP-65EIJ7OI\Documents\SECOND course\designPatterns\Lab03\Proxy\NewFile2.doc"; // => Access denied! (regex : @".*\.txt")
            try
            {
                var newReader = new SmartTextReader();
                newReader.ReadTextFromFile(filePath);
                newReader.PrintTextArray();

                IReader logger = new SmartTextChecker(newReader);
                logger.ReadTextFromFile(filePath);
                
                IReader lockerReader = new SmartTextReaderLocker(logger,  @".*\.txt");
                lockerReader.ReadTextFromFile(filePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}