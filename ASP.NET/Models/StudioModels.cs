using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Filmy.Models
{
    public class StudioModels
    {
        public int ID { get; set; }         //kazda klasa musi miec ID

        [Display(Name = "Nazwa studia")]
        public string Nazwa { get; set; }   //nazwa studia
        [Display(Name = "Logo")]
        public string Logo { get; set; }    //logo studia

        public virtual ICollection<FilmyModels> Filmy { get; set; } //do jednego studia przypisane sa filmy

    }
}