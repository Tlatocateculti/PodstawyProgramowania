using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace PodstawyProgramowania.Model
{
    public class OsobyGrid : ObservableCollection<Osoba>
    {
        public OsobyGrid() : base() {
            /*DataGridTextColumn dataGridColumn = new DataGridTextColumn();
            dataGridColumn.Header = "Imię";
            dataGridColumn.Binding = new Binding("Imie");
            this.Add(dataGridColumn);*/
           
        }

        public void AddSomething()
        {
            SqlConnection sqlConnection = new("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\admin\\Documents\\testowabaza.mdf;Integrated Security=True;Connect Timeout=30");
            sqlConnection.Open();            
            
            this.Add(new Osoba() { Id_Osoba = 1, Id_Stanowisko = 2, Imie = "Jarosław", Nazwisko = "Kuczak" });
            this.Add(new Osoba() { Id_Osoba = 2, Id_Stanowisko = 2, Imie = "Amelia", Nazwisko = "Łatkowska" });
        }
    }
}
