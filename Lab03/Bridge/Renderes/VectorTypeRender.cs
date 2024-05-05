using Bridge.Shapes;

namespace Bridge.Renderes;

public class VectorTypeRender : IRender
{
    public void RenderConcreteShape(Shape shape)
    {
        Console.WriteLine($"Drawing {shape.GetType().Name} like vector graphics way");
    }
}