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

namespace Wecker
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

        private void btnTerminHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Termin termin;
            try
            {
                //byte bspStunden;
                //bool bspConvertierung = byte.TryParse(txtBxStunden.Text, out bspStunden);  // BSP TryParse konvertierung

                byte stunden = Convert.ToByte(txtBxStunden.Text);
                byte minuten = Convert.ToByte(txtBxMinuten.Text);
                if ((stunden <= 23 && stunden >= 0) && (minuten <= 59 && minuten >= 0))
                {
                    termin = new Termin(txtBxTitel.Text, stunden, minuten); // 
                    txtBxTitel.Text = "";
                    txtBxStunden.Text = "";
                    txtBxMinuten.Text = "";
                    lstBxTermine.Items.Add(termin.ToString());
                }
                else
                {
                    MessageBox.Show(/*TODO:...*/"Fehler");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(/*TODO:...*/"Fehler CATCH");
            }
        }

        private void btnTerminLoeschen_Click(object sender, RoutedEventArgs e)
        {
            int i = lstBxTermine.SelectedIndex; // "index" von ausgewaehlten Element aus ListBox
            if (i >= 0)
                lstBxTermine.Items.RemoveAt(i); // entfernt das Element am angegebenen Index 
        }
    }
}
