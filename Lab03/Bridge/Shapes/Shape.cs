namespace Bridge.Shapes;
using Renderes;
public abstract class Shape
{
    protected IRender _render;

    protected Shape(IRender render)
    {
        _render = render;
    }

    public abstract void Draw();
}