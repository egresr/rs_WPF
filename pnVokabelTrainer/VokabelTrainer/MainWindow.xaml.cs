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

namespace VokabelTrainer
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        Vokabel aktuelleVokabel;
        Random random = new Random();
        Vokabel[] vokabular = new Vokabel[3];

        public MainWindow()
        {        
            InitializeComponent();

            vokabular[0] = new Vokabel("hallo", "hello");
            vokabular[1] = new Vokabel("gehen", "to go");
            vokabular[2] = new Vokabel("gut", "good");


            FelderAusfuellen();      

            lblDatumHinzugefuegt.Content = aktuelleVokabel.ErstellungsDatum.ToShortDateString();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            if (aktuelleVokabel.Pruefe(txtBxAngabe.Text))
            {
                FelderAusfuellen();
                
            }      
            else
            {

                lblDatumLetzteAbfrage.Content = aktuelleVokabel.LetzteAbfrage;
                lblZaehlerRichtig.Content = aktuelleVokabel.ZahlKorrekteAbfragen;
                lblZaehlerFalsch.Content = aktuelleVokabel.ZahlFehlgeschlageneAbfragen;

                MessageBox.Show("Leider falsch!");
            }
        }

        private void FelderAusfuellen()
        {
            aktuelleVokabel = vokabular[random.Next(vokabular.Length)];
            lblAbfrage.Content = aktuelleVokabel.DeutschesWort;
            lblZaehlerRichtig.Content = aktuelleVokabel.ZahlKorrekteAbfragen;
            lblZaehlerFalsch.Content = aktuelleVokabel.ZahlFehlgeschlageneAbfragen;
            lblDatumLetzteAbfrage.Content = aktuelleVokabel.LetzteAbfrage;
            txtBxAngabe.Text = "";
        }
    }
}
