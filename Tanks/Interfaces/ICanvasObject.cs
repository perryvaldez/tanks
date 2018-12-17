using System;

namespace Interfaces
{
    public class TickArgs
    {
        public ICanvas Canvas { get; set; }
    }

    public interface ICanvasObject
    {
        void OnTick(TickArgs args);
    }
}
