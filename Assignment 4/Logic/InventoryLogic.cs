using AssignmentFourLibrary.Models;
using System;
using System.Collections.Generic;

namespace AssignmentFourLibrary.Logic
{
    class InventoryLogic
    {
        public static ProductModel AddProduct(string name, string desc, decimal price)
        {
            ProductModel product = new ProductModel(name, desc, price);

            return product;
        }

        public static ProcedureModel AddProcedure(string name, string desc, decimal price, int minutes)
        {
            ProcedureModel procedure = new ProcedureModel(name, desc, price, minutes);

            return procedure;
        }
    }
}
