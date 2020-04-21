using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class Machine
    {
        [DisplayName("Machine Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZæøåÆØÅ]+$", ErrorMessage = "Kun danske bogstaver tilladt i {0}")]
        [DisplayName("Machine Name")]
        public string Name { get; set; }

        [DisplayName("Time Of Task")]
        public TimeSpan RunTime { get; set; }

        [DisplayName("Field")]
        public Field Field { get; set; }
    }
}
