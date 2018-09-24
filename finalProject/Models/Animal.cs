using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace finalProject.Models
{
    public class Animal
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Animal Name")]
        public string AnimalName { get; set; }  // individual name ex "Fred"

        [Required]
        [Display(Name ="Animal Type")]
        public string AnimalType { get; set; }  // type of animal ex "bear"

        [Required]
        [Display(Name ="Zoo Location")]
        public string AnimalZooLocation { get; set; } // city location of zoo ex "San Diego"

        [Required]
        [Display(Name ="Diet Type")]
        public string FoodClass { get; set; } // classes would be omnivore,herbivore, and carnivore
        



    }
}