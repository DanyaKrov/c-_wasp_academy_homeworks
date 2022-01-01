using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF3
{
    class Plus_and_min : UIElement
    {
        private Button[] buttons = new Button[2];
        private Thickness margin;
        private double width;
        private double height;

        public Plus_and_min()
        {
            buttons[0] = new Button();
            buttons[1] = new Button();
        }
        override protected void OnVisualParentChanged(DependencyObject e)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(buttons[0]);
            grid.Children.Add(buttons[1]);
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                buttons[0].Width = value / 2;
                buttons[1].Width = value / 2;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                buttons[0].Height = value / 2;
                buttons[1].Height = value / 2;
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
                Thickness temp = value;
                temp.Left -= width;
                buttons[0].Margin = temp;
                temp.Left += width;
                buttons[1].Margin = temp;
            }
        }
        private void Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button) == buttons[0]){
            }
            else
            {
            }
        }
    }
}
