using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;

namespace practic_123
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            settings1 Frm1 = new settings1();
            Frm1.Show();
            Hide();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Information Frm2 = new Information();
            Frm2.Show();
            Hide();
        }
      

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtEditor.Text = " ";
            if (stackPanelAdd.Children.Count > 0)
            {
                stackPanelAdd.Children.RemoveAt(stackPanelAdd.Children.Count - 1);
            }
        }

            private void EXIT_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (stackPanelAdd.Children.Count > 0)
            {
                stackPanelAdd.Children.RemoveAt(stackPanelAdd.Children.Count - 1);
            }
        }

        private void Button_PNG(object sender, RoutedEventArgs e)
        {
            StackPanel sp = new StackPanel();
            Image tb = new Image();
            sp.Children.Add(tb);
            stackPanelAdd.Children.Add(sp);
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                tb.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void Button_music(object sender, RoutedEventArgs e)
        {
            Player taskWindow = new Player();
            taskWindow.Owner = this;
            taskWindow.Show();
        }

        private void Button_BD(object sender, RoutedEventArgs e)
        {
            BD taskWindow = new BD();
            taskWindow.Owner = this;
            taskWindow.Show();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Background = brush;
        }
    }
}
