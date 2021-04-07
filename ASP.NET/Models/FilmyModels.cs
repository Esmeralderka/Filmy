using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Filmy.Models
{
    public class FilmyModels
    {
        [Key]
        public int ID { get; set; }             //kazda klasa musi miec ID

        [Display(Name = "Dlugosc")]
        public int? Dlugosc { get; set; }        //czas trwania filmu


        [Display(Name = "Tytul")]
        public string Tytul { get; set; }       //tytul filmu


        [Display(Name = "Plakat")]
        public string Plakat { get; set; }      //zdjecie promocyjne

        [Display(Name = "Opis")]
        public string Opis { get; set; }       //opis filmu
         
      
        public int GatunekID { get; set; }      //laczy sie z gatunkiem, przez to id
       
        public int StudioID { get; set; }      //laczy sie ze studiem, przez to id
        public virtual GatunekModels Gatunek    //filmy wiedza z jakiego sa gatunku
        {
            get; set;
        }
        public virtual StudioModels Studio    //filmy wiedza z jakiego sa studia
        {
            get; set;
        }
    }
}