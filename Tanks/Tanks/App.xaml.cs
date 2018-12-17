using Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Tanks
{  
    public partial class App : Application
    {
        private List<ICanvasObject> canvasObjects = new List<ICanvasObject>();
        private DispatcherTimer globalTimer = new DispatcherTimer();

        public List<ICanvasObject> CanvasObjects { get; }
        public DispatcherTimer GlobalTimer { get; }

        public App()
        {
            canvasObjects.Add(new Samples.SampleTank());

            CanvasObjects = canvasObjects;
            GlobalTimer = globalTimer;

            globalTimer.Tick += GlobalTimer_Tick;
            globalTimer.Interval = new TimeSpan(0, 0, 1);
            globalTimer.Start();
        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            var win = (MainWindow) Application.Current.MainWindow;
            ObjectRenderer renderer = new ObjectRenderer(win.cvsCanvas);

            foreach (var obj in this.CanvasObjects)
            {
                var args = new TickArgs();
                obj.OnTick(args);
                renderer.Render(obj);
            }
        }
    }
}
