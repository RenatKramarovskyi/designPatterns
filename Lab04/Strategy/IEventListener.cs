namespace Observer
{
    public interface IEventListener
    {
        void Subscribe(string eventType, EventHandler handler);
        void Unsubscribe(string eventType, EventHandler handler);
    }
}