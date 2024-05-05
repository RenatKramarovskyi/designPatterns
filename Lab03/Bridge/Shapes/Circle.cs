using Bridge.Renderes;

namespace Bridge.Shapes;

public class Circle : Shape
{
    public override void Draw()
    {
       _render.RenderConcreteShape(this);
    }

    public Circle(IRender render) : base(render)
    {
    }
}