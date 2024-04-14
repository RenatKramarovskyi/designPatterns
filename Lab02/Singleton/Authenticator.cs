namespace Singleton;

public class Authenticator
{
    private static Authenticator _instance = null;
    private static object lockCreate = new object();
    
    private Authenticator()
    {
    }

    public static Authenticator CreateInstance()
    {
        if (_instance == null)
        {
            lock (lockCreate)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
            }
        }
        return _instance;
    }
}