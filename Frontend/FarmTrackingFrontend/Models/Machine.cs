using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackendLibrary.Models {
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double RunTime { get; set; }
        public Field Field { get; set; }
    }
}
