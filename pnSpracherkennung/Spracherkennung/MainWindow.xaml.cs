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
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Spracherkennung
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
            Choices theChoices = new Choices();
            theChoices.Add("Bielefeld");
            theChoices.Add("Gütersloh");
            theChoices.Add("Minden");
            theChoices.Add("Neuss");
            theChoices.Add("Düsseldorf");
            theChoices.Add("Köln");
            theChoices.Add("Christian");
            theChoices.Add("Irina");
            SpeechRecognizer recognizer = new SpeechRecognizer();
            recognizer.LoadGrammar(new Grammar(new GrammarBuilder(theChoices)));
            recognizer.SpeechRecognized += speechRecognized;
            recognizer.Enabled = true;
        }

        void speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            label.Content = e.Result.Text;

        }
    }
}
