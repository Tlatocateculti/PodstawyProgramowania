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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PodstawyProgramowania.Model;

namespace PodstawyProgramowania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DbContextOptionsBuilder dbOptionsBuilder = new DbContextOptionsBuilder<FirmaDB>();
            dbOptionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\Documents\\testowabaza.mdf;Integrated Security=True;Connect Timeout=30");
           
            FirmaDB db = new(dbOptionsBuilder.Options);
            /*var query = db.Osoby
                       .Where(s => s.Imie == "Janina")
                       .FirstOrDefault<Osoba>();*/
            var query = from osoba in db.Osoby
                        /*where osoba.Imie == "Janina"*/
                        select osoba;
            foreach(var row in query)
            {
                Console.WriteLine(row);
            }
            var Osoba = new Osoba() { Imie = "Marianna", Nazwisko = "Więcławska", Id_Stanowisko = 1 };
            //db.Osoby.Add(Osoba);
            //db.SaveChanges();
            db.Osoby.Remove(Osoba);
            db.SaveChanges();
        }
    }
}
