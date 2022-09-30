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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cuadroEscribir_TextChanged(object sender, TextChangedEventArgs e)
        {
            cuadroCopia.Text = cuadroEscribir.Text;
        }

        private void negrita_Checked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.FontWeight = FontWeights.Bold;
        }

        private void negrita_Unchecked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.FontWeight = FontWeights.Normal;
        }

        private void cursiva_Checked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.FontStyle = FontStyles.Italic;
        }

        private void cursiva_Unchecked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.FontStyle = FontStyles.Normal;
        }

        private void rojo_Checked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.Foreground = Brushes.Red;
        }

        private void verde_Checked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.Foreground = Brushes.Green;
        }

        private void Azul_Checked(object sender, RoutedEventArgs e)
        {
            cuadroCopia.Foreground = Brushes.Blue;
        }
    }
}