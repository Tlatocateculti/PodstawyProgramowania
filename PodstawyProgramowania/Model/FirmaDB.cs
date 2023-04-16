using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PodstawyProgramowania.Model
{
    internal class FirmaDB : DbContext
    {
        public FirmaDB(DbContextOptions db) : base(db) { }
                          
        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Stanowisko> Stanowiska { get; set; }  
    }
}
