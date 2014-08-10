using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mario_Kart_Toolkit
{
    public partial class FadeInWindow:Window
    {
        DispatcherTimer timer;
        public FadeInWindow()
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Start();
            Opacity = 0;
        }

        void timerTick(object sender, EventArgs e)
        {
            Opacity += 0.03;
            if (Opacity > 1)
            {
                Opacity = 1;
                timer.Stop();
            }
        }
    }
}
