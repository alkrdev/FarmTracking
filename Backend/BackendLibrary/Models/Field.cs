using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class Field
    {
        [DisplayName("Field Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZæøåÆØÅ]+$", ErrorMessage = "Kun danske bogstaver tilladt i {0}")]
        [DisplayName("Field Name")]
        public string Name { get; set; }

        [DisplayName("Active Machine")]
        public ActiveMachine ActiveMachine { get; set; }
    }
}
