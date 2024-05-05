namespace Adapter;

public class FileWriter
{
    public string Write(string msg)
    {
        return $"Message \"{msg}\" was wrote in file successfully";
    }

    public string WriteLine(string msg)
    {
        return $"Message \"{msg}\" was wrote in file with enter successfully";
    }
}