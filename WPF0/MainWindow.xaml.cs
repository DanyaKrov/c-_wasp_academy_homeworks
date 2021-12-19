using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace WPF0
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void _box_MouseEnter(object sender, MouseEventArgs arg)
        {
            box.Focus();
        }
        private void buttonx_click(object sender, RoutedEventArgs arg)
        {
            if (no.Content != null)
                no.Content = null;
            box.Clear();
        }

        private void tick_click(object sender, RoutedEventArgs arg)
        {
            string temp = box.Password;
            box.Clear();
            if (temp == "12345")
            {
                no.Foreground = new SolidColorBrush(Color.FromRgb(10, 140, 60));
                no.Content = "CORRECT INPUT";
            }
            else
            {
                no.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                no.Content = "WRONG INPUT";
            }
        }

        private void pin_changed(object sender, RoutedEventArgs arg)
        {
            if (no.Content != null)
                no.Content = null;
        }

        private void _box_KeyDown(object sender, KeyEventArgs key)
        {
            if (key.Key == Key.Enter) 
                tick_click(sender, key);
            else if (no.Content != null)
                no.Content = null;
        }

        private void button0_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "0";
        }

        private void button9_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "9";
        }

        private void button8_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "8";
        }

        private void button7_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "7";
        }

        private void button6_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "6";
        }

        private void button5_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "5";
        }

        private void button4_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "4";
        }

        private void button3_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "3";
        }

        private void button2_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "2";
        }

        private void button1_click(object sender, RoutedEventArgs arg)
        {
            box.Password += "1";
        }
    }
}