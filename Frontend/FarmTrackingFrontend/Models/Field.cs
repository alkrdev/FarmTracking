﻿namespace FarmTrackingFrontend.Models
{
    public class Field
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ActiveMachine ActiveMachine { get; set; }
    }
}
