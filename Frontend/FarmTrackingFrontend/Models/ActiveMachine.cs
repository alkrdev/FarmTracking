using System.ComponentModel;

namespace FarmTrackingFrontend.Models
{
    public class ActiveMachine {
        public int Id { get; set; }
        public string MachineName { get; set; }
        public string FieldName { get; set; }
        public double TimeLeft { get; set; }
    }
}
