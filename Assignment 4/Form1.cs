using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AssignmentFourLibrary.Logic;
using AssignmentFourLibrary.Models;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        List<ProductModel> productList = new List<ProductModel>();
        List<ProcedureModel> procedureList = new List<ProcedureModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            productList.Add(InventoryLogic.AddProduct(
                txtProdName.Text, 
                txtProdDesc.Text, 
                Convert.ToDecimal(txtProdPrice.Text)));

            lbProducts.Items.Clear();

            foreach(var product in productList)
            {
                lbProducts.Items.Add($"{product.Name}");
            }

            ClearText();
        }

        public void ClearText()
        {
            foreach(var control in Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

                if (control is RichTextBox)
                {
                    ((RichTextBox)control).Clear();
                }
            }
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                productList.RemoveAt(lbProducts.SelectedIndex);

                lbProducts.Items.Clear();

                foreach (var product in productList)
                {
                    lbProducts.Items.Add($"{product.Name}");
                }
            }
            catch(Exception)
            {

            }

            ClearText();
        }

        private void btnProcSave_Click(object sender, EventArgs e)
        {
            procedureList.Add(InventoryLogic.AddProcedure(
                txtProcName.Text,
                txtProcDesc.Text, 
                Convert.ToDecimal(txtProcPrice.Text), 
                Convert.ToInt32(txtProcMinutes.Text)));

            lbProcedures.Items.Clear();

            foreach (var procedure in procedureList)
            {
                lbProcedures.Items.Add($"{procedure.Name}");
            }

            ClearText();
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtProdName.Text = lbProducts.Items[lbProducts.SelectedIndex].ToString();
                txtProdDesc.Text = productList[lbProducts.SelectedIndex].Description;
                txtProdPrice.Text = productList[lbProducts.SelectedIndex].Price.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void lbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtProcName.Text = lbProcedures.Items[lbProcedures.SelectedIndex].ToString();
                txtProcDesc.Text = procedureList[lbProcedures.SelectedIndex].Description;
                txtProcPrice.Text = procedureList[lbProcedures.SelectedIndex].Price.ToString();
                txtProcMinutes.Text = procedureList[lbProcedures.SelectedIndex].Minutes.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnProcDelete_Click(object sender, EventArgs e)
        {
            try
            {
                procedureList.RemoveAt(lbProcedures.SelectedIndex);

                lbProcedures.Items.Clear();

                foreach (var procedure in procedureList)
                {
                    lbProcedures.Items.Add($"{procedure.Name}");
                }
            }
            catch (Exception)
            {

            }

            ClearText();
        }
    }
}
