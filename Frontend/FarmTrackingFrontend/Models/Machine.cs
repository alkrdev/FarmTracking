using System;

namespace FarmTrackingFrontend.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan RunTime { get; set; }
        public Field Field { get; set; }
    }
}
