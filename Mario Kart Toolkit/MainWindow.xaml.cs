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
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;

namespace Mario_Kart_Toolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer;

        DoubleAnimation panelOpen, panelClose;

        bool isPanelOpen;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Start();
            Opacity = 0;

            //Initialize the animations
            panelOpen = new DoubleAnimation(1280, 1580, new Duration(new TimeSpan(0, 0, 0, 0, 500)), FillBehavior.Stop);
            panelOpen.EasingFunction = new SineEase();
            panelClose = new DoubleAnimation(1580, 1280, new Duration(new TimeSpan(0, 0, 0, 0, 500)), FillBehavior.Stop);
            panelClose.EasingFunction = new SineEase();
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

        private void CloseButtonMouseEnter(object sender, MouseEventArgs e)
        {
            CloseButton.Effect = new BlurEffect();
            CloseButton.Foreground = Brushes.Red;
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CloseButtonMouseLeave(object sender, MouseEventArgs e)
        {
            CloseButton.Effect = null;
            CloseButton.Foreground = Brushes.Gray;
        }

        private void MinimizeButtonMouseLeave(object sender, MouseEventArgs e)
        {
            MinimizeButton.Effect = null;
            MinimizeButton.Foreground = Brushes.Gray;
        }

        private void MinimizeButtonMouseEnter(object sender, MouseEventArgs e)
        {
            MinimizeButton.Effect = new BlurEffect();
            MinimizeButton.Foreground = Brushes.Orange;
        }

        private void MinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            WindowState = System.Windows.WindowState.Minimized;
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void NavButtonMouseEnter(object sender, MouseEventArgs e)
        {
            NavPanelButton.Effect = new BlurEffect();
            NavPanelButton.Foreground = Brushes.Aquamarine;
        }

        private void NavButtonMouseLeave(object sender, MouseEventArgs e)
        {
            NavPanelButton.Effect = null;
            NavPanelButton.Foreground = Brushes.Gray;
        }

        private void NavPanelToggle(object sender, RoutedEventArgs e)
        {
            isPanelOpen = !isPanelOpen;
            if (isPanelOpen)
            {
                BeginAnimation(WidthProperty, panelOpen);
                NavPanelButton.Content = '\uf138';
            }
            else
            {
                BeginAnimation(WidthProperty, panelClose);
                NavPanelButton.Content = '\uf137';
            }
        }

    }
}
