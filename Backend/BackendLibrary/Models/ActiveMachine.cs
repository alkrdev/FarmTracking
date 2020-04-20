using System;
using System.Collections.Generic;
using System.Text;

namespace BackendLibrary.Models {
    public class ActiveMachine {
        public int Id { get; set; }
        public Machine Machine { get; set; }
        public Field Field { get; set; }
        public int MachineId { get; set; }
        public int FieldId { get; set; }
        public TimeSpan TimeLeft { get; set; }
    }
}
