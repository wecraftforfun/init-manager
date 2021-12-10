using System.ComponentModel.DataAnnotations;

namespace InitManager.Data
{
    public class Unit
    {
        [RegularExpression(@"^.{3,}$", ErrorMessage = "Minimum 3 characters required")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Maximum 100 characters")]
        public string Name { get; set; }
        public int InitRoll { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsPlayer { get; set; }
        public string PlayedBy { get; set; }

        public bool HasPlayed { get;set; }

    }
}
