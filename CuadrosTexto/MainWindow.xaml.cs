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

namespace CuadrosTexto
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

        private void fTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBox textBoxAComprobar = sender as TextBox;

                if (textBoxAComprobar == nombreTextBox)
                    ayudaNombreTextBlock.Text = textBoxAComprobar.Tag.ToString();
                else
                    ayudaApellidoTextBlock.Text = textBoxAComprobar.Tag.ToString();
                 
            }
            if (e.Key == Key.F2)
            {
                validarEdadTextBlock.Text = Int32.TryParse(edadTextBox.Text.ToString(), out _) ? "" : "Edad incorrecta";
            }

        }
    }
}
