using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class ActiveMachine {
        [DisplayName("Active machine Id")]
        public int Id { get; set; }

        [DisplayName("machine")]
        public Machine machine { get; set; }

        [DisplayName("field")]
        public Field field { get; set; }

        [DisplayName("machine Id")]
        public int MachineId { get; set; }

        [DisplayName("field Id")]
        public int FieldId { get; set; }

        [DisplayName("Time Left")]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan TimeLeft { get; set; }
        public bool Active { get; set; }
    }
}
