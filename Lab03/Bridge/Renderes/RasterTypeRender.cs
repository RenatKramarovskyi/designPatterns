namespace Bridge.Renderes;
using Shapes;

public class RasterTypeRender : IRender
{
    public void RenderConcreteShape(Shape shape)
    {
        Console.WriteLine($"Drawing {shape.GetType().Name} like raster graphics way");
    }
}