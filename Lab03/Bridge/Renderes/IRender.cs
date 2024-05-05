namespace Bridge.Renderes;
using Shapes;

public interface IRender
{
    void RenderConcreteShape(Shape shape);
}