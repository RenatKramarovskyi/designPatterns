namespace Composite
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public class AnyElementsNode : LightNode
    {
        public string Title { get; }
        public bool IsBlock { get; }
        public bool IsSelfClosing { get; }
        public List<string> ClassList { get; }
        public List<LightNode> Childrens { get; }

        public AnyElementsNode(string title, bool isBlock, bool isSelfClosing, List<string> classList, List<LightNode> childrens)
        {
            Title = title;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
            ClassList = classList ?? new List<string>(); 
            Childrens = childrens ?? new List<LightNode>();
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