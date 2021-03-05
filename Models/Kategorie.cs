using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    [Table("Kategoria")]
    public class Kategoria
    {
        [Key]
        [Display(Name = "Identyfikator kategorii:")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać nazwę kategorii.")]
        [MaxLength(50, ErrorMessage = "Nazwa kategorii nie może być dluższa niż 50 znaków")]
        [Display(Name = "Nazwa kategorii:")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Czy Kategorie jest aktywna")]
        [Display(Name = "Czy wyświetlać?")]
        public bool Aktywna { get; set; }

        [Required(ErrorMessage = "Wprowadź opis kategorii.")]
        [Display(Name = "Opis kategorii:")]
        public string Opis { get; set; }

        [Display(Name = "Czy wyświetlać na stronie głównej?")]
        public bool? Informacja { get; set; }

        // witualna lista tekstów należących do tej kategorii

        public virtual ICollection<Watek> Watki { get; set; }
    }
}