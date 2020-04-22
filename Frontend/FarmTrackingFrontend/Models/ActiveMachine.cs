using System;
using System.ComponentModel;

namespace FarmTrackingFrontend.Models
{
    public class ActiveMachine {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string FieldName { get; set; }
        public DateTime TimeLeft { get; set; }
    }
}
