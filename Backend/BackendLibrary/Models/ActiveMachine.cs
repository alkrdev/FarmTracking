using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class ActiveMachine {
        [DisplayName("Active Machine Id")]
        public int Id { get; set; }

        [DisplayName("Machine")]
        public Machine Machine { get; set; }

        [DisplayName("Field")]
        public Field Field { get; set; }

        [DisplayName("Machine Id")]
        public int MachineId { get; set; }

        [DisplayName("Field Id")]
        public int FieldId { get; set; }

        [DisplayName("Time Left")]
        public TimeSpan TimeLeft { get; set; }
        public bool Active { get; set; }
    }
}
