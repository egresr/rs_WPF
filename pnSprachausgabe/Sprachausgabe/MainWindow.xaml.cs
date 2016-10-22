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
using System.Speech.Synthesis;

namespace Sprachausgabe
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            DateTime dt = DateTime.Now;

            sp.SpeakAsync(textBox.Text);    //Text aus texBox Akustisch ausgeben            
            sp.SpeakAsync(dt.ToLongTimeString()); //Aktuelle Zeit Akustisch ausgeben 

        }
    }
}
