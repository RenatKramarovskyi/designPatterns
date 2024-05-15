using System;

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
                new AnyElementsNode("button", false, false, new List<string> { "pretty" }, null)
            };
           
            var cssClasses = new List<string> { "title", "important" };
            var elementNode = new AnyElementsNode("div", true, false, cssClasses, childrens);

            Console.WriteLine(elementNode.OuterHtml);

            if (elementNode is IEventListener)
            {
                var eventListener = (IEventListener)elementNode;
                eventListener.Subscribe("click", (sender, e) =>
                {
                    TestClickMethod(); 
                });
            }
            
            elementNode.RaiseEvent("click", EventArgs.Empty);
            elementNode.RaiseEvent("click", EventArgs.Empty);
            
        }

        public static void TestClickMethod() //method that should be executed after the button is clicked
        {
            Console.WriteLine("Message from subscribed method");
        }
    }
}