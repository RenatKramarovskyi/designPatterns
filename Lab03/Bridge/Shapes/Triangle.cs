using Bridge.Renderes;

namespace Bridge.Shapes;

public class Triangle : Shape
{
    public override void Draw()
    {
        _render.RenderConcreteShape(this);

    }

    public Triangle(IRender render) : base(render)
    {
    }
}