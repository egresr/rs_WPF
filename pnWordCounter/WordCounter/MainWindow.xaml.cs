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

                for (int i = 0; i < parts.Length; i++) // fuer jeden element aus Array "parts"
                {
                    if (parts[i] != "") // pruefen ob string leer ist
                    {
                        bool istVorhanden = false;
                        for (int j = 0; j < words.Count; j++) // fuer jeden objekt "word" aus Liste "words"
                        {
                            if (words[j].Text == parts[i]) // vergleichen string aus Array parts mit jedem Feld "text" von Objekt "word" aus Liste "words"  
                            {
                                words[j].Count = 1;  
                                istVorhanden = true; 
                                break;
                            }
                        }

                        if (!istVorhanden)
                            words.Add(new Word(parts[i].Trim())); //wenn keine uebereinstimmungen in pruefung Zeile 59, dann
                                                                  // in Liste "words" neus Objekt typ Word erstellen.
                    }
                }

                var tmpAlphabet = words.OrderBy(x => x.Text).ToList(); // Alphabetisch sortiert
                var tmpCountAbsteigend = words.OrderBy(x => -x.Count).ToList();  // Absteigend nach Count sortiert
                var tmpCountAufsteigend = words.OrderBy(x => x.Count).ToList();  // Aufsteigend nach Count sortiert
            }

            //TODO: Das ist ein TEST "TODO: Kommentare/ Aufgabenliste"           // Es werden alle "TODO"-Angezeigt

            string stopStop = "---STOP---STOP---STOP---";
        }
    }
}
