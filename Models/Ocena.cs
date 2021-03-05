using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    [Table("Ocena")]
    public class Ocena
    {
        [Key]
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Id użytkownika. ")]
        public string IdUzytkownika { get; set; }

        [Required]
        [Display(Name = "Id Postu.")]
        public int IdPostu { get; set; }

        [ForeignKey("IdPostu")]
        [InverseProperty("Oceny")]
        public virtual Post Post { get; set; }

        [Display(Name = "Ocena komentarza")]
        public int Wartosc { get; set; }
    }
}