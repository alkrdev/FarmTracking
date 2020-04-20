using System;
using System.Collections.Generic;
using System.Text;

namespace BackendLibrary.Models {
    public class Field { 
        public int Id { get; set; }
        public string Name { get; set; }
        public ActiveMachine ActiveMachine { get; set; }
    }
}
