using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Filmy.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Filmy.DAL
{
    public class FilmyContext : DbContext
    {
        public FilmyContext()
        : base()
        {
            Database.SetInitializer(new FilmyBazaInizializer<FilmyContext>());
        }
        public DbSet<FilmyModels> Film { get; set; }

        public DbSet<UzytkownicyModels> Uzytkownik { get; set; }
        public DbSet<WypozyczeniaModels> Wypozyczenia { get; set; }
        public DbSet<GatunekModels> Gatunek { get; set; }
        public DbSet<StudioModels> Studio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         
        }
    }
}
    