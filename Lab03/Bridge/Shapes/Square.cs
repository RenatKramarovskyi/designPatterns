using Bridge.Renderes;

namespace Bridge.Shapes;

public class Square : Shape
{
    public override void Draw()
    {
        _render.RenderConcreteShape(this);
    }

    public Square(IRender render) : base(render)
    {
    }
}