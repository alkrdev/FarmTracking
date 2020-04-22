using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class Machine
    {
        [DisplayName("machine Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-ZæøåÆØÅ]+$", ErrorMessage = "Kun danske bogstaver tilladt i {0}")]
        [DisplayName("machine Name")]
        public string Name { get; set; }

        [DisplayName("Time Of Task")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan RunTime { get; set; }

        [DisplayName("field")]
        public Field Field { get; set; }
    }
}
