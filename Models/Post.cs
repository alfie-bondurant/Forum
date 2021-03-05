using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać treść komentarza.")]
        [Display(Name = "Treść komentarza:")]
        [DataType(DataType.MultilineText)]
        public string Tresc { get; set; }

        [Display(Name = "Data dodania:")]
        [DataType(DataType.Date, ErrorMessage = "Niepoprawny format daty")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public System.DateTime DataDodania { get; set; }

        // definiowanie powiązań miedzy tabelami
        [Display(Name = "Komentowany post")]
        public int IdWatku { get; set; }

        [ForeignKey("IdWatku")]
        [InverseProperty("Posty")]
        public virtual Watek Watek { get; set; }

        // definiowanie powiązań miedzy tabelami
        [Display(Name = "Autor komentarza")]
        public string IdUzytkownika { get; set; }
    
        public virtual ICollection<Ocena> Oceny { get; set; }
    }
}