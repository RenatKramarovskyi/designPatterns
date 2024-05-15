namespace Observer;

public class TextNode : LightNode
{
    public string Text { get; }

    public TextNode(string text)
    {
        this.Text = text;
    }

    public override string OuterHtml => this.Text;
    public override string InnerHtml => this.Text;
}