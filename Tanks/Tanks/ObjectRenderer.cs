using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tanks
{
    public class ObjectRenderer
    {
        private Canvas canvas;

        public ObjectRenderer(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void Render(ICanvasObject obj)
        {

        }
    }
}
