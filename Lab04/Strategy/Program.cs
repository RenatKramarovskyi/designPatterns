using System;
using System.Collections.Generic;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var textNode3 = new TextNode("Im in span");
            var spanChildrens = new List<LightNode>
            {
                textNode3
            };

            var blockNode1 = new AnyElementsNode("span", true, false, null, spanChildrens);

            var childrens = new List<LightNode>
            {
                new TextNode("Text node 1 "),
                new TextNode("Text node 2 "),
                blockNode1,
                new AnyElementsNode("br", true, true, null, null),
                new AnyElementsNode("button", false, false, new List<string> { "pretty" }, null),
                new ImageNode("C:/cats/cutekitty.jpg", new ImgFromLocalStrategy()), //just example
                    new ImageNode("http://thecutestanimals.com/images?q=tbn:ANd9GcSOEdPW2XWgS9sHDS-UDKCR_IIcxze3xBEaqg&s", new ImgFromNetworkStrategy()) 
            };
           
            var cssClasses = new List<string> { "title", "important" };
            var elementNode = new AnyElementsNode("div", true, false, cssClasses, childrens);

            Console.WriteLine(elementNode.OuterHtml);

            foreach (var node in childrens)
            {
                if (node is ImageNode)
                {
                    var imageNode = (ImageNode)node;
                    imageNode.LoadImage();
                }
            }
        }
    }
}