using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public Information()
        {
            InitializeComponent();
        }

     
        private void Back_button(object sender, RoutedEventArgs e)
        {
            MainWindow Frm0 = new MainWindow();
            Frm0.Show();
            Hide();
        }


        private void hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("");

        }

        private void open_github(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
