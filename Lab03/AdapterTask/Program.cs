
namespace Adapter
{
    public class Program
    {
        public static void Main()
        {

            Logger logger = new Logger();

            logger.Error("Error 8078 : ...");
            logger.Log("Process finished with exit code 0");
            logger.Warn("Here is probably a duplicate");
            
            ILogger filesLogs = new Adapter(new FileWriter());
            filesLogs.Log("Process finished with exit code 0");
        }
    }
}