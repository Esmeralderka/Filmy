using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace Filmy.Models
{
    public class GatunekModels
    {
        public int ID { get; set; }         //kazda klasa musi miec ID
     

        [Display(Name = "Gatunek")]
        public string Nazwa {get;set;}      //Nazwa gatunku (dramat, komedia, horror, animowany, akcja)

        public virtual ICollection<FilmyModels> Filmy { get; set; } //do jednego gatunku przypisane sa filmy

    }
}