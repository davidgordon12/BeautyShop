﻿namespace AssignmentFourLibrary.Models
{
    class ProcedureModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Minutes { get; set; }

        public ProcedureModel(string name, string description, decimal price, int minutes)
        {
            Name = name;
            Description = description;
            Price = price;
            Minutes = minutes;
        }
    }
}
