using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Book { get; set; }

        [Range(1, 100)]
        [Required]
        public int Chapter { get; set; }

        [Range(1, 150)]
        [Required]
        public int Verse { get; set; }

        [Required]
        public string? Note { get; set; }

        
        [Required]
        [Display(Name = "Recorded Date")]
        [DataType(DataType.Date)]
   
        public DateTime RecordedDate { get; set; }
    }
}
