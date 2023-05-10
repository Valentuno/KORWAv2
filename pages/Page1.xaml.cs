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

namespace pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void kalkulaotr_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double pojemnosc = Convert.ToDouble(pojemnosc_box.Text);
                double procent = Convert.ToDouble(procent_box.Text);
                double cena = Convert.ToDouble(cena_box.Text);
                if (pojemnosc < 1 || procent < 0 || cena < 0.01)
                {
                    throw new ArgumentException("Nieprawidłowe wartości");
                }
                else
                {
                    double etanol = pojemnosc * (procent / 100);
                    etanol_box.Text = Convert.ToString(etanol);

                    double koszt = etanol / cena;
                    zl_box.Text = Convert.ToString(koszt);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Błędny format podanych wartości", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Nieprawidłowe wartości.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

       
    }
}
