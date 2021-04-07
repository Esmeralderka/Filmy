using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Filmy.Models
{
    public class WypozyczeniaModels
    {
        public int ID { get; set; }                  //kazda klasa musi miec ID

        [Required]
        public int FilmID { get; set; }              //dzieki temu bedzie sie laczylo z filmami
        [Required]
        public int UzytkownicyID { get; set; }       //dzieki temu bedzie sie laczylo z uzytkownikmi

        [Required]
        public string Data { get; set; }       

        public string Film_Tytul { get; set; }

        public virtual FilmyModels Filmy             //wiadomo jaki film jest wypozyczony
        {
            get; set;
        }

        public virtual UzytkownicyModels Uzytkownicy  //wiadomo jaki uzytkownik wypozyczal
        {
            get; set;
        }
    }
}