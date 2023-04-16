using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using PodstawyProgramowania.Model;

namespace PodstawyProgramowania.Widok
{
    /// <summary>
    /// Logika interakcji dla klasy Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public OsobyGrid OsobaGrid { get; set; }

        public Start()
        {
            InitializeComponent();
            OsobaGrid = new();
            OsobySiatka.ItemsSource = OsobaGrid;
        }

        private void OsobySiatka_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void StronaSiatka_Loaded(object sender, RoutedEventArgs e)
        {
            OsobaGrid.AddSomething();
            //OsobaGrid.Add(new Osoba() { Id_Osoba = 1, Id_Stanowisko = 2, Imie = "Jarosław", Nazwisko = "Kuczak" });
        }

        private void OsobySiatka_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Console.WriteLine("Zakonczono edycje!");
        }

        private void OsobySiatka_Delete(object sender, RoutedEventArgs e)
        {
            OsobaGrid.Remove((Osoba)OsobySiatka.CurrentItem);
            //Console.WriteLine(OsobySiatka.CurrentItem);
        }
    }
}
