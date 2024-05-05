namespace Adapter
{
    public class Adapter : ILogger
    {
        private readonly FileWriter _writer;

        public Adapter(FileWriter writer)
        {
            this._writer = writer;
        }

        public void Log(string msg)
        {
            Console.WriteLine($"From adapter | {_writer.WriteLine(msg)} |");
        }

        public void Warn(string msg)
        {
            Console.WriteLine($"From adapter | {_writer.WriteLine(msg)} | ");
        }

        public void Error(string msg)
        {
            Console.WriteLine($"From adapter | {_writer.Write(msg)}");
        }
    }
}