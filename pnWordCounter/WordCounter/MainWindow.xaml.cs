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
using Microsoft.Win32;
using System.IO;

namespace WordCounter
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

        private void btnAnalyse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog(); // ein neue Objekt erstellen und die Referenz
                                                                          // in der variable "dialog" speichern

            bool? result = dialog.ShowDialog(); // (bool? - ja,nein,weis nicht)
                                                // mach Dialog auf, warte auf ein Ergebnis und speichere in der Variable "result"

            if (result == true) // weil "result" hat Typ "bool?" man muß "if(result == true)" verwenden, anstat if(result)
            {
                string text = File.ReadAllText(dialog.FileName);
                string[] parts = text.Split(new char[] { ' ', '.', ':', ';', '?', '!', '"', '\n', '\r' }); // string "text" trennen. 
                                                                                                           // als Trennzeichen werden die Zeichen
                                                                                                           // aus neu erstellten Array benutzt.
                                                                                                           // und die getrennte Woerter in
                                                                                                           // array "parts" speichern.
                List<Word> words = new List<Word>();
                int zaehlerTest = 0;
                foreach (var item in parts)
                {
                    lblTest.Content = " ###";
                    foreach (var word in words)
                    {
                        if (word.Text == item)
                        {
                            //TODO: ...
                            zaehlerTest++;
                            MessageBox.Show(zaehlerTest.ToString());
                            break;
                        }
                    }
                    Word wrd = new Word();

                    words.Add(wrd);
                    lblTest.Content = " 000";
                }

            }


            string stopStop = "---STOP---STOP---STOP---";
        }
    }
}
