using AssignmentFourLibrary.Models;
using System;
using System.Collections.Generic;

namespace AssignmentFourLibrary.Logic
{
    class ProductLogic
    {
        public void AddItem(string name, string desc, decimal price)
        {
            ProductModel product = new ProductModel(name, desc, price);

            InventoryModel inventory = new InventoryModel();

            inventory.
        }
    }
}
