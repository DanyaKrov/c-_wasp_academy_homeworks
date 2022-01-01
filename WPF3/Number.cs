using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF3
{
    class Number : UIElement
    {
        private TextBox box;
        private Thickness margin;
        private double width;
        private double height;

        public Number()
        {
            box = new TextBox();
    }
        override protected void OnVisualParentChanged(DependencyObject e)
        {
            Grid grid = VisualParent as Grid;
            grid.Children.Add(box);
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
                box.Width = width;
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
                box.Height = height;
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
                box.Margin = temp;
            }
        }
    }
}
