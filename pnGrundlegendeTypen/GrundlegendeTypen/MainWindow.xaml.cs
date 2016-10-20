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

            int z = int.MaxValue;//gibt Max-Wert von int
            double aaa = double.MinValue;//gibt Min-Wert von double
            double a = double.NaN;//Not a number = Keine Zahl. BSP wurzel von -1, oder teilen durch Null
            double aa = double.NegativeInfinity;//Minus Unendlich

            if (double.IsNaN(a)) { /*...*/ }//Pruefung ob es um ein Zahl geht


        }
    }
}