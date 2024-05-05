namespace Adapter;

public interface ILogger
{
    public void Log(string msg);
    public void Warn(string msg);
    public void Error(string msg);

}