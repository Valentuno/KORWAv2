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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        Alkohol[] alkohols = new Alkohol[]
        {
            new Alkohol(0,"Harnas","15g/zl","5","Zdjecia/harnas.jpg"),
            new Alkohol(1,"Halne","20g/zl","3","Zdjecia/halne.jpg"),
        };


        public Page2()
        {
            InitializeComponent();

            Mylist.ItemsSource = alkohols;
        }
    }
}
