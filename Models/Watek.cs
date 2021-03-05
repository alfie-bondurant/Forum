using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    [Table("Watek")]
    public class Watek
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tytuł Postu")]
        [MaxLength(75, ErrorMessage = "Post nie może przekraczać 75 znaków")]
        public string Tytul { get; set; }

        [Display(Name = "Słowa kluczowe")]
        [MaxLength(255, ErrorMessage = "Słowa kluczowe nie mogą być dłuższe niż 255 znaków")]
        public string SlowaKluczowe { get; set; }

        [Display(Name = "Grafika do Postu")]
        [MaxLength(128)]
        public string Grafika { get; set; }

        [Required]
        [Display(Name = "Czy wyświetlać?")]
        public bool Aktywny { get; set; }

        [Required]
        [Display(Name = "Data dodania")]
        [DataType(DataType.Date, ErrorMessage = "Niepoprawny format daty")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DataDodania { get; set; }

        [Required]
        [Display(Name = "Kategorie tekstu:")]
        public int IdKategorii { get; set; }

        [ForeignKey("IdKategorii")]
        [InverseProperty("Watki")]
        public virtual Kategoria Kategoria { get; set; }

        [Required]
        [Display(Name = "Autor Postu:")]
        public string IdUzytkownika { get; set; }

        public virtual ICollection<Post> Posty { get; set; }
    }
}