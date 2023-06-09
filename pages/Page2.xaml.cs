﻿using System;
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
        public Alkohol[] alkohols = new Alkohol[]
        {
        new Alkohol(0,"Harnas","15g/zl","5"),
        new Alkohol(1,"Halne","20g/zl","3")
        };

        public Page2()
        {
            InitializeComponent();

            Random rnd = new Random();
            int index = rnd.Next(alkohols.Length);
            Alkohol wylosowanyAlkohol = alkohols[index];

            string b1 = wylosowanyAlkohol.Title;

            Mylist.ItemsSource = alkohols;

            TEST_LB.Items.Add(b1);
        }
    }
}
