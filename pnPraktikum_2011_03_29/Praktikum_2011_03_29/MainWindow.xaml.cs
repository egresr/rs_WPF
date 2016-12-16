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

namespace Praktikum_2011_03_29
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

        private void buttoHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            AlarmTime alarmTime = new AlarmTime();
            alarmTime.name = textBoxName.Text;



            if (alarmTime.stunde >= 0 && alarmTime.stunde <= 23)
                alarmTime.stunde = int.Parse(textBoxStunde.Text);
            else
                alarmTime.stunde = 0;

            if (alarmTime.minute >= 0 && alarmTime.minute <= 59)
                alarmTime.minute = int.Parse(textBoxMinute.Text);
            else
                alarmTime.minute = 0;

            listBoxWecker.Items.Add(alarmTime);
        }

        private void buttonLoeschen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
