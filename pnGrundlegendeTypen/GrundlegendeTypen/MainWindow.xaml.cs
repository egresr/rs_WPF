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

namespace GrundlegendeTypen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //
            //Zahl->Zeichenkette
            //
            int z = int.MaxValue;//gibt Max-Wert von int
            double aaa = double.MinValue;//gibt Min-Wert von double
            double a = double.NaN;//Not a number = Keine Zahl. BSP wurzel von -1, oder teilen durch Null
            double aa = double.NegativeInfinity;//Minus Unendlich

            if (double.IsNaN(a)) { /*...*/ }//Pruefung ob es um ein Zahl geht
            string b = aaa.ToString();
            string c = aaa.ToString("0.###E-000");//double in string mit formatierung. 1 Platz vor Komma, 3 Plaetze nach Komma, Exponente wenn negativ mit "-"-Zeichen und 3Stellen)

            //
            //Zeichenkette->Zahl
            //
            int d = int.Parse("123");//von String nach Zahl

            try//hier werden mögliche Fehler abgefangen
            {
                int f = int.Parse("abc");
            }
            catch
            {
                /*...*/
            }

            int g;
            bool ok = int.TryParse("123", out g);
            ok = int.TryParse("abc", out g);

            //
            //Zeichenketten
            //
            string h = "abc*";
            string i = h + "xyz*" + d + "*uvw";//Zeichenketten an ein anderen haengen
            int j = i.Length; //Zeichenkette laenge
            string k = i.Substring(2,3); // von string ab Position 2, 3 Stueck auswaehlen
            bool l = i.StartsWith("abc"); // string faeng an mit "abc"?
            int m = i.IndexOf("xyz"); //bei welchem index die Zeichenketteteil "xyz" steht, als Teil von Zeichenkette "i" . Wird als Suchfunction benutzt.
            string[] n = i.Split('*'); //trennt eine string an '*' und speichert in eine Array

            //
            //Zeichenketten vergleichen
            //
            if(h == "bla") { /*...*/ }
            if (h.CompareTo("aaa") > 0){ /*...*/} // Alphabetische vergleich



            //
            //Array
            //
            int[] arrA = new int[7]; // Array mit 7 Antraegen
            int[] arrB = { 4, 5, 3, 2, 5, 7, 4, 3 }; //Initialisieren
            int cc = arrB.Length; // Array laenge ermitteln
            int dd = Array.IndexOf(arrB, 7); //an welche Stelle steht Zahl 7.
            int ee = Array.FindIndex(arrB, x=> x >= 6 );//ein Antrag suchen der >= 6 ist. Fuer jedes Ding in dem Array, nehme dieses Ding (Stellvertreter "x") und rechne aus ob "x" >= 6 ist. INDEX wird ausgegeben. Anonyme Funktion. Lambda Asudruck

            //
            //Array Functionen
            //
            int[] gg = foo(arrB);

            //
            //Mehrdimensionale Arrays
            //
            int[,] arrH = new int[3, 4]; //3-Hoch(Zeilen) und 4-Breit(Spalten)
            arrH[2, 1] = 13; // Zeile Nr. 2 und Spalte Nr. 1 auf 13 setzen
            int[,] arrI = { {1, 2}, {3, 4}, {5,6 } };

            //
            //jagged Array. Ein Array von Arrays
            //
            int[][] arrJ = new int[5][]; //Array von 5-Array's wird erzeugt (Zeilen)
            for (int kk = 0; kk < 5; kk++)
            {
                arrJ[kk] = new int[13 * kk + 7]; // 5-Zeilen Array "arrJ" wird mit Array's verschiedener Laenge (Spalten) gefuellt.
            }
            arrJ[2][3] = 13; // in Array "arrJ" in Zeile mit dem Index 2, in der Spalte 3 von da liegenden Array


            //
            //Aufzaehlungen (Enumeration)
            //
            State mm = State.FullPower; //BSP Aufzehlungen benutzen
            switch (mm)
            {
                case State.FullPower:
                    /*...*/
                    break;
                case State.HalfPower:
                    /*...*/
                    break;
                case State.Error:
                    /*...*/
                    break;
                case State.Off:
                    /*...*/
                    break;
                default:
                    break;
            }

            //
            //Enum Functionen
            //

            string s = m.ToString();
            int nn = (int)m;
            string tt = Enum.GetName(typeof(State), 1);
            State uu = (State)Enum.Parse(typeof(State), "HalfPower");
            int vv = (int)Enum.Parse(typeof(State), "HalfPower");





            int stop = 1111;
        }
        //
        //Array Functionen
        //
        int[] foo(int[] x) // als Argument wir KEINE Kopie uebergeben, sonder REFERENZ
        {
            int s = x.Sum();
            int[] y = { s, 2 * s, 3 * s };
            return y; //es wird eine Referenz zurueck gegeben
        }

        //
        //Aufzaehlungen (Enumeration)
        //
        enum State { FullPower, HalfPower, Error, Off }; //das sind Namen für Zahlen, ab 0
    }
}