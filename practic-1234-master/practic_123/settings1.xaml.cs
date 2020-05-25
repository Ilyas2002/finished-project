using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace practic_123
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class settings1 : Window
    {
        public settings1()
        {
            InitializeComponent();
        }
        private void Back_button(object sender, RoutedEventArgs e)
        {
            MainWindow Frm0 = new MainWindow();
            Frm0.Show();
            Hide();
        }
    }
}
