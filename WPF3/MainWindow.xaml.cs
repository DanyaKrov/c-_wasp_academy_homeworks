using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF3
{
    public partial class MainWindow : Window
    {
        WPF3 box = new WPF3();
        public MainWindow()
        {
            InitializeComponent();
            box.Width = 600;
            box.Height = 900;
            box.Background = new SolidColorBrush(Color.FromRgb((byte)255, (byte)255, (byte)255));
            box.Foreground = new SolidColorBrush(Color.FromRgb((byte)0, (byte)0, (byte)0));
            mainGrid.Children.Add(box);
        }
    }
    public class WPF3 : UIElement
    {
        private TextBox number = new TextBox();
        private Button minus = new Button() { Content = "-" };
        private Button plus = new Button() { Content = "+" };
        private double high;
        private double wide;
        private int value;
        private Thickness margin;

        public WPF3()
        {
            number.TextChanged += toStr;
            minus.Click += decrease;
            plus.Click += increase;
        }
        public int Num
        {
            get
            {
                return value;
            }
            set
            {
                number.Text = value.ToString();
                this.value = value;
                ChangeValue();
            }
        }

        public double Height
        {
            get
            {
               return high;
            }
            set
            {
                number.Height = high = value;
                plus.Height = minus.Height = value / 2;
            }
        }

        public double Width
        {
            get
            {
                return wide;
            }
            set
            {
                wide = value;
                number.Width = value / 3 * 2;
                plus.Width = minus.Width = value / 3;
            }
        }

        public Thickness Margin
        {
            get
            {
                return margin;
            }
            set
            {
                margin = value;
                number.Margin = value;
                value.Left += number.Width + plus.Width;
                value.Top -= plus.Height;
                plus.Margin = value;
                value.Top += number.Height;
                minus.Margin = value;
            }
        }

        public Brush Foreground
        {
            get
            {
                return number.Foreground;
            }
            set
            {
                number.Foreground = value;
                plus.Foreground = value;
                minus.Foreground = value;
            }
        }
        private void ChangeValue()
        {
            RaiseEvent(new RoutedEventArgs(ValueChange, this));
        }
        public Brush Background
        {
            get
            {
                return number.Background;
            }
            set
            {
                number.Background = value;
                plus.Background = value;
                minus.Background = value;
            }
        }

        private void decrease(object sender, RoutedEventArgs e)
        {
            Num--;
        }

        private void increase(object sender, RoutedEventArgs e)
        {
            Num++;
        }
        public event RoutedEventHandler ValueChanged
        {
            add
            {
                AddHandler(ValueChange, value);
            }
            remove
            {
                RemoveHandler(ValueChange, value);
            }
        }
        private void toStr(object sender, TextChangedEventArgs e)
        {
            number.Text = value.ToString();
        }

        protected override void OnVisualParentChanged(DependencyObject oldParent)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(number);
            grid.Children.Add(minus);
            grid.Children.Add(plus);
        }

        public readonly RoutedEvent ValueChange = EventManager.RegisterRoutedEvent("ValueChanged", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(WPF3));
    }
}
