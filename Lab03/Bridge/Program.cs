namespace Bridge
{
    using Shapes;
    using Renderes;
    
    public class Program
    {
        public static void Main(string[] args)
        {
            IRender vectorRender = new VectorTypeRender();
            IRender rasterRender = new RasterTypeRender();

            Shape[] shapes =
            {
                new Circle(vectorRender),
                new Square(rasterRender),
                new Triangle(vectorRender)
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

        }
    }
}