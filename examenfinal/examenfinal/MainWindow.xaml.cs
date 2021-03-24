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

namespace examenfinal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num1, num2, respuesta;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnCero_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void txtResultado_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnUno_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void btnDos_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void btnTres_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void btnCuatro_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void btnCinco_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void btnSeis_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void btnSiete_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btnOcho_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btNueve_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void btnRespuesta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMultiplicación_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            num1 = (int)txtResultado; 
        }
    }
}
