using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InitManager.Data
{
    public class Campaign
    {

        public Campaign()
        {
            Units = new List<Unit>();
        }

        [RegularExpression(@"^.{3,}$", ErrorMessage = "Minimum 3 characters required")]
        [Required(ErrorMessage = "Required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Maximum 30 characters")]
        public string Name { get; set; }

        public List<Unit> Units { get; set; }


        public override bool Equals(object obj)
        {
            
            if (obj is Campaign)
            {
                var c = obj as Campaign;
                if(c.Name == Name)
                {
                    return true;
                }
            }
            return false;
            
        }

        public override int GetHashCode()
        {
            if(!string.IsNullOrEmpty(Name))
            {
                return Name.GetHashCode();
            }
            return 0;
        }
    }
}
