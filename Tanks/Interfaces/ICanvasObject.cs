using System;

namespace Interfaces
{
    public class TickArgs
    {
    }

    public interface ICanvasObject
    {
        void OnTick(TickArgs args);
    }
}
