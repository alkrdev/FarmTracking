using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class Field
    {
        [DisplayName("field Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZæøåÆØÅ]+$", ErrorMessage = "Kun danske bogstaver tilladt i {0}")]
        [DisplayName("field Name")]
        public string Name { get; set; }

        [DisplayName("Active machine")]
        public ActiveMachine ActiveMachine { get; set; }
    }
}
