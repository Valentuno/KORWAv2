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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void BTN_Strzal_Click(object sender, RoutedEventArgs e)
        {
            Random Strzal = new Random();
            int a1 = Strzal.Next(1, 31);
            for ()
            LB_strzal.Items.Clear();

            LB_strzal.Items.Add(a1.ToString());
        }
    }
}
