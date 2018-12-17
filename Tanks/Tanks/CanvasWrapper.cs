using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tanks
{
    public class CanvasWrapper : ICanvas
    {
        Canvas rawCanvas;

        public CanvasWrapper(Canvas canvas)
        {
            rawCanvas = canvas;
        }
    }
}
