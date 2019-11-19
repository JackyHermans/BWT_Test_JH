using Microsoft.Win32;
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
using System.IO;

namespace BWT_JH
{
    /// <summary>
    /// Interaction logic for BWT_Test_JH.xaml
    /// </summary>
    public partial class BWT_Test_JH : Window
    {
        public BWT_Test_JH()
        {
            InitializeComponent();          
        }

        private void WaardeOpslaan(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                string directorynaam = @"C:\BWT_Test_JH";

                if (!Directory.Exists(directorynaam))
                {
                    Directory.CreateDirectory(directorynaam);
                }
                else
                {
                    string bestandsnaam = "Waardes.txt";
                    string bestand = directorynaam + @"\" + bestandsnaam;
                    string wegTeSchrijven = GekozenWaarde.ToString();
                    
                    if (!File.Exists(bestand))
                    {
                        File.WriteAllText(bestand, wegTeSchrijven);
                    }
                    else
                    {
                        File.AppendAllText(bestand, wegTeSchrijven);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("opslaan mislukt: " + ex.Message);
            }
        }

    }
}
