using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PodstawyProgramowania.Model
{
    [Table("Stanowiska")]
    class Stanowisko
    {
        [Key]
        public int Id_Stanowisko { get; set; }
        public string? Nazwa { get; set; }
        public decimal Premia { get; set; }

        /*public Stanowisko(string nazwa) { Nazwa = nazwa; }

        public Stanowisko(string nazwa, decimal premia) { Nazwa = nazwa; Premia = premia; }

        public Stanowisko(int id_stanowisko, string nazwa, decimal premia) { Id_Stanowisko = id_stanowisko; Nazwa = nazwa; Premia = premia; }

        public override string ToString()
        {
            return base.ToString();
        }*/


    }
}
