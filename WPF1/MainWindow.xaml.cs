using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomizer = new Random();
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(tick);
            timer.Interval = new TimeSpan(0, 0, 3);
            timer.Start();
        }
        public void tick(object sender, EventArgs args)
        {
            Button button = new Button
            {
                Background = new SolidColorBrush(Color.FromRgb((byte)randomizer.Next(256), (byte)randomizer.Next(256), (byte)randomizer.Next(256))),
                Width = 100,
                Height = 50,
                Margin = new Thickness
                {
                    Left = randomizer.Next(-310, 310),
                    Top = randomizer.Next(-600, 600)
                },
                Content = ("Click"),
                Foreground = new SolidColorBrush(Color.FromRgb((byte)randomizer.Next(256), (byte)randomizer.Next(256), (byte)randomizer.Next(256))),
                FontSize = randomizer.Next(12, 32)
            };
            place.Children.Add(button);
            button.MouseEnter += restart;
        }
        public void restart(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            button.Margin = new Thickness
            {
                Left = randomizer.Next(-310, 310),
                Top = randomizer.Next(-600, 600)
            };
        }
    }
}
