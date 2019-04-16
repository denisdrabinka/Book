using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MyFirstProject2
{
    /// <summary>
    /// Interaction logic for Video.xaml
    /// </summary>
    public partial class Video : Window
    {

        DispatcherTimer timer = new DispatcherTimer();

        public TimeSpan Position { get; set; }

        public Video()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += timer_tick;
            media1.Play();
            timer.Start();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            media1.Position = Position;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            time.Text = media1.Position.ToString(@"mm\:ss");
            sliderback2.Value = media1.Position.TotalSeconds;
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Play();
            timer.Start();
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Pause();
            timer.Stop();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Stop();
            timer.Stop();
            media1.Position = Position;
        }

        private void media1_MediaOpened(object sender, RoutedEventArgs e)
        {
            slider2.Maximum = media1.NaturalDuration.TimeSpan.TotalSeconds;
            sliderback2.Maximum = media1.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media1 != null)
            {
                media1.Volume = slider1.Value;
            }
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            media1.Pause();
            media1.Position = TimeSpan.FromSeconds(slider2.Value);
            media1.Play();
        }


        private void forwardButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Pause();
            media1.Position = media1.Position + TimeSpan.FromSeconds(5);
            media1.Play();

        }

        private void backwardsButton_Click(object sender, RoutedEventArgs e)
        {
            media1.Pause();
            media1.Position = media1.Position - TimeSpan.FromSeconds(5);
            media1.Play();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.media1.Close();
        }
    }

}

