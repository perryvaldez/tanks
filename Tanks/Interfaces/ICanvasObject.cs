namespace Interfaces
{
    public delegate void EventType();

    public interface ICanvasObject
    {
        event EventType OnTick;
    }
}
