using Composite;

namespace LightWeight
{
    using System.IO;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            
            string filePath = @"C:\Users\renat.LAPTOP-65EIJ7OI\Documents\SECOND course\designPatterns\Lab03\LightWeight\RomeoandJuliet.txt";

            List<LightNode> nodes = ReadBookText(filePath);

            var cssClasses = new List<string> { "root-book" };
            var rootElement = new AnyElementsNode("div", true, false, cssClasses, nodes);

            Console.WriteLine(rootElement.OuterHtml);
            long memoryBefore = GC.GetTotalMemory(false);
            Console.WriteLine($"Total memory before creating the tree: {memoryBefore} bytes");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            long memoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine($"Total memory after creating the tree: {memoryAfter} bytes");
        }

        private static List<LightNode> ReadBookText(string filePath)
        {
            List<LightNode> nodes = new List<LightNode>();
            bool isFirstLine = true;

            using (var reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        nodes.Add(new AnyElementsNode("h1", true, false, null, new List<LightNode> { new TextNode(line) }));
                        isFirstLine = false;
                    }
                    else
                    {
                        LightNode node;
                        if (line.Length < 20)
                        {
                            node = new AnyElementsNode("h2", true, false, null, new List<LightNode> { new TextNode(line) });
                        }
                        else if (line.StartsWith(" "))
                        {
                            node = new AnyElementsNode("blockquote", true, false, null, new List<LightNode> { new TextNode(line) });
                        }
                        else
                        {
                            node = new AnyElementsNode("p", true, false, null, new List<LightNode> { new TextNode(line) });
                        }

                        nodes.Add(node);
                    }
                }
            }

            return nodes;
        }
    }
}
