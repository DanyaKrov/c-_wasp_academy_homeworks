using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace WPF2
{
    public partial class MainWindow : Window
    {
        int r, g, b;
        Thickness startMargin;
        List<Button> buttons;
        List<Button> buttons_not_num;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button> { button0, button1, button2, button3, button4, button5,
                button6, button7, button8, button9 };
            buttons_not_num = new List<Button>{ buttonx, yes};
            startMargin = box.Margin;
            slider.ValueChanged += slider_ValueChanged;
            foreach (Button button in buttons)
            {
                button.Click += IfNullContent;
                button.Click += RandomSwap;
                button.Click += Click;
                button.Click += RandomPasswordBoxMove;
            }
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += RandomSwap;
            timer.Start();
        }

        private void IfNullContent(object sender, EventArgs e)
        {
            if (buttons[0].Content != null) 
                return;
            for (int i = 0; i < 10; i++)
            {
                buttons[i].Content = Convert.ToString(i);
            }
        }

        private void RandomSwap(object sender, EventArgs e)
        {
            List<Button> button_0 = buttons.GetRange(0, 10);
            for (int i = 9; i >= 0; i--)
            {
                Button button_1 = button_0[random.Next(0, i)];
                r = random.Next(20, 255);
                g = random.Next(20, 255);
                b = random.Next(20, 255);
                button_1.Background = new SolidColorBrush(Color.FromRgb((byte)r, (byte)g, (byte)b));
                button_1.Foreground = new SolidColorBrush(Color.FromRgb((byte)(255 - r), (byte)(255 - g), (byte)(255 - b)));
                button_1.Content = 9 - i;
                button_0.Remove(button_1);
            }
            foreach (Button button in buttons_not_num)
                button.Background = new SolidColorBrush(Color.FromArgb((byte)random.Next(20, 255), (byte)random.Next(20, 255), (byte)random.Next(20, 255), (byte)random.Next(20, 255)));
        }

        private void Clear_click(object sender, RoutedEventArgs e)
        {
            box.Margin = startMargin;
            box.Clear();
        }

        private void box_MouseEnter(object sender, MouseEventArgs e)
        {
            no.Content = null;
            box.Focus();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            box.Password += (sender as Button).Content;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            no.Content = $"{slider.Value}";
        }
        private void Check_click(object sender, RoutedEventArgs e)
        {
            if (box.Password == "12345")
            {
                no.Foreground = new SolidColorBrush(Color.FromRgb(10, 255, 10));
                no.Content = "CORRECT PIN";
            }
            else
            {
                no.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                no.Content = "WRONG PIN";
            }
            box.Clear();
        }
        private void box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) 
                Check_click(sender, e);
        }
        private void RandomPasswordBoxMove(object sender, EventArgs e)
        {
            Thickness margin = box.Margin;
            if (random.Next(1, 3) == 1)
            {
                margin.Left -= 10;
            }

            else
            {
                margin.Left += 10;
            }

            box.Margin = margin;
        }
    }
}
