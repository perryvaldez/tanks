using Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Samples
{
    public class SampleTank : ICanvasObject
    {
        public void OnTick(TickArgs args)
        {
            Debug.WriteLine("Test");
        }
    }
}
