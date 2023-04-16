using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyProgramowania.Model
{
    [Table("Osoby")]
    public class Osoba
    {
        [Key]
        public int Id_Osoba { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        [ForeignKey("Id_Stanowisko")]
        public int Id_Stanowisko { get; set; }
    }
}
