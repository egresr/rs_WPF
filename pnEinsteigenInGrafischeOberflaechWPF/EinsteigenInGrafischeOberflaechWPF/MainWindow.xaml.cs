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

namespace EinsteigenInGrafischeOberflaechWPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbtnIce_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(">>> ICE <<<");
        }

        private void rbtnRegio_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = dtPckr.SelectedDate.ToString();
        }
    }
}
