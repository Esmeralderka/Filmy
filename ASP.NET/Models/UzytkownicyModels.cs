using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Filmy.Models
{
    public class UzytkownicyModels
    {
        public int ID { get; set; }                     //kazda klasa musi miec ID

        [Display(Name = "Nazwa uzytkownika")]
        public string Nazwa { get; set; }               //nazwa uzytkownika


        public IEnumerable<FilmyModels> Filmy_Lista { get; set; }//bo user wie jakie filmy wypozyczyl

    }
}