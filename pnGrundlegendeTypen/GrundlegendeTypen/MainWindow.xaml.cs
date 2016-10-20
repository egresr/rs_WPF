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
        int variableCCC;
        int variablvariableEEEE;
        int[] variablevariableDDD;

        public MainWindow()
        {
            InitializeComponent();
            Test();
            TestTest();
        }
        
        public void Test()
        {
            int a = 2;
            int b = 3;
            int c;
            string txt = "BSP Text Test";

            c = a + b;
            variableCCC = c;
        }

        public void TestTest()
        {
            int a = 12;
            int b = 13;
            int[] d = new int[4];
            string txt = "BSP Text TestTest";

            d[0] = a;
            d[1] = b;
            d[2] = d[0] + d[1];

            variablvariableEEEE = d.Length;
        }

        private void btnKoordinatenAusgeben_Click(object sender, RoutedEventArgs e)
        {
            int koordinateX;
            int koordinateY;

            int.TryParse(txtBxX.Text, out koordinateX);
            int.TryParse(txtBxY.Text, out koordinateY);

            Point p = new Point(koordinateX, koordinateY);
            p.koordinateX = 100;

            lblX.Content = p.koordinateX;
            lblY.Content = p.koordinateY;
        }
    }

    class Point
    {
        public int koordinateX { get; set; }
        public int koordinateY { get; set; }

        public Point(int _koordinateX, int _koordinateY)
        {
            koordinateX = _koordinateX;
            koordinateY = _koordinateY;
        }        
    }
}
