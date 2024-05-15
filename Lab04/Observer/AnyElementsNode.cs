using System;
using System.Text;

namespace Observer
{
    public class AnyElementsNode : LightNode, IEventListener
    {
        public string Title { get; }
        public bool IsBlock { get; }
        public bool IsSelfClosing { get; }
        public List<string> ClassList { get; }
        public List<LightNode> Childrens { get; }

        private Dictionary<string, List<EventHandler>> eventHandlers;

        public AnyElementsNode(string title, bool isBlock, bool isSelfClosing, List<string> classList, List<LightNode> childrens)
        {
            Title = title;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            ClassList = classList ?? new List<string>(); 
            Childrens = childrens ?? new List<LightNode>();
            eventHandlers = new Dictionary<string, List<EventHandler>>();
        }

        public void Subscribe(string eventType, EventHandler handler)
        {
            if (!eventHandlers.ContainsKey(eventType))
            {
                eventHandlers[eventType] = new List<EventHandler>();
            }
            eventHandlers[eventType].Add(handler);
        }

        public void Unsubscribe(string eventType, EventHandler handler)
        {
            if (eventHandlers.ContainsKey(eventType))
            {
                eventHandlers[eventType].Remove(handler);
            }
        }

        public void RaiseEvent(string eventType, EventArgs args)
        {
            if (eventHandlers.ContainsKey(eventType))
            {
                foreach (var handler in eventHandlers[eventType])
                {
                    handler.Invoke(this, args);
                }
            }
        }
        
        public override string OuterHtml
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{this.Title}");

                if (ClassList.Count > 0)
                {
                    sb.Append($" class=\"{string.Join(" ", ClassList)}\"");
                }
                
                if (IsSelfClosing)
                {
                    sb.Append("/>");
                }
                else
                {
                    sb.Append(">");

                    foreach (var child in Childrens)
                    {
                        sb.Append(child.OuterHtml);
                    }

                    sb.Append($"</{Title}>");
                }
                return sb.ToString();
            }
        }

        public override string InnerHtml
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in Childrens)
                {
                    sb.Append(child.OuterHtml);
                }

                return sb.ToString();
            }
        }
    }
}
