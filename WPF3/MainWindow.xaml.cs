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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF3
{
    public partial class MainWindow : Window
    {
        Plus_and_min button = new Plus_and_min();
        Number box = new Number();
        public MainWindow()
        {
            InitializeComponent();
            button.Width = 600;
            button.Height = 900;
            button.Margin = new Thickness(0, 900, 600, 0);
            mainGrid.Children.Add(button);
            box.Width = 600;
            box.Height = 900;
            box.Margin = new Thickness(0, 0, 0, 0);
            mainGrid.Children.Add(box);
        }
        private void box_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void box_MouseEnter(object sender, MouseEventArgs e)
        {
            box.Focus();
        }
    }
}
