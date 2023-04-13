using Entities_.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class PersonelDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=DESKTOP-JA53S8S;Database=PersonelTakipSistemi; 
                  Integrated Security=True");
        }
        public DbSet<Bolumler> Bolumlers { get; set; }
        public DbSet<Personeller> Personellers { get; set; }
        public DbSet<Gorevler> Gorevlers { get; set; }  
        public DbSet<Ogrenim_Durumlar> Ogrenim_Durumlars { get; set; }
       
        }
        
    }

