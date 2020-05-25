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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using Color = System.Windows.Media.Color;
using System.Diagnostics;

namespace practic_123
{
    /// <summary>
    /// Логика взаимодействия для BD.xaml
    /// </summary>
    public partial class BD : Window
    {
        public BD()
        {
            InitializeComponent();
        }

        private void Button_EXIT(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_CONNECTION(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Подключено!", "Соединение с БД");
        }

    }
}
