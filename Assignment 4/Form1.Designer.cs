
namespace Assignment_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProdSave = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.txtProdDesc = new System.Windows.Forms.RichTextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProdUpdate = new System.Windows.Forms.Button();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.txtProcMinutes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.txtProcDesc = new System.Windows.Forms.RichTextBox();
            this.btnProcDelete = new System.Windows.Forms.Button();
            this.btnProcUpdate = new System.Windows.Forms.Button();
            this.btnProcSave = new System.Windows.Forms.Button();
            this.lbProcedures = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProdSave
            // 
            this.btnProdSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdSave.Location = new System.Drawing.Point(360, 253);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(102, 35);
            this.btnProdSave.TabIndex = 4;
            this.btnProdSave.Text = "Save New";
            this.btnProdSave.UseVisualStyleBackColor = true;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 19;
            this.lbProducts.Location = new System.Drawing.Point(12, 80);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(128, 536);
            this.lbProducts.TabIndex = 1;
            this.lbProducts.TabStop = false;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDesc.Location = new System.Drawing.Point(448, 119);
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(375, 79);
            this.txtProdDesc.TabIndex = 2;
            this.txtProdDesc.Text = "";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(448, 86);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(294, 27);
            this.txtProdName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Beauty Shop Maintenance";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrice.Location = new System.Drawing.Point(448, 204);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(100, 27);
            this.txtProdPrice.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // btnProdUpdate
            // 
            this.btnProdUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdUpdate.Location = new System.Drawing.Point(561, 253);
            this.btnProdUpdate.Name = "btnProdUpdate";
            this.btnProdUpdate.Size = new System.Drawing.Size(102, 35);
            this.btnProdUpdate.TabIndex = 5;
            this.btnProdUpdate.Text = "Update";
            this.btnProdUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdDelete.Location = new System.Drawing.Point(748, 253);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(102, 35);
            this.btnProdDelete.TabIndex = 6;
            this.btnProdDelete.Text = "Delete";
            this.btnProdDelete.UseVisualStyleBackColor = true;
            this.btnProdDelete.Click += new System.EventHandler(this.btnProdDelete_Click);
            // 
            // txtProcMinutes
            // 
            this.txtProcMinutes.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcMinutes.Location = new System.Drawing.Point(448, 542);
            this.txtProcMinutes.Name = "txtProcMinutes";
            this.txtProcMinutes.Size = new System.Drawing.Size(100, 27);
            this.txtProcMinutes.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Minutes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(340, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Products:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(340, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Procedures:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price:";
            // 
            // txtProcPrice
            // 
            this.txtProcPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcPrice.Location = new System.Drawing.Point(448, 509);
            this.txtProcPrice.Name = "txtProcPrice";
            this.txtProcPrice.Size = new System.Drawing.Size(100, 27);
            this.txtProcPrice.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Name:";
            // 
            // txtProcName
            // 
            this.txtProcName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcName.Location = new System.Drawing.Point(448, 391);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(294, 27);
            this.txtProcName.TabIndex = 7;
            // 
            // txtProcDesc
            // 
            this.txtProcDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcDesc.Location = new System.Drawing.Point(448, 424);
            this.txtProcDesc.Name = "txtProcDesc";
            this.txtProcDesc.Size = new System.Drawing.Size(375, 79);
            this.txtProcDesc.TabIndex = 8;
            this.txtProcDesc.Text = "";
            // 
            // btnProcDelete
            // 
            this.btnProcDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcDelete.Location = new System.Drawing.Point(748, 591);
            this.btnProcDelete.Name = "btnProcDelete";
            this.btnProcDelete.Size = new System.Drawing.Size(102, 35);
            this.btnProcDelete.TabIndex = 13;
            this.btnProcDelete.Text = "Delete";
            this.btnProcDelete.UseVisualStyleBackColor = true;
            this.btnProcDelete.Click += new System.EventHandler(this.btnProcDelete_Click);
            // 
            // btnProcUpdate
            // 
            this.btnProcUpdate.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcUpdate.Location = new System.Drawing.Point(561, 591);
            this.btnProcUpdate.Name = "btnProcUpdate";
            this.btnProcUpdate.Size = new System.Drawing.Size(102, 35);
            this.btnProcUpdate.TabIndex = 12;
            this.btnProcUpdate.Text = "Update";
            this.btnProcUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProcSave
            // 
            this.btnProcSave.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcSave.Location = new System.Drawing.Point(360, 591);
            this.btnProcSave.Name = "btnProcSave";
            this.btnProcSave.Size = new System.Drawing.Size(102, 35);
            this.btnProcSave.TabIndex = 11;
            this.btnProcSave.Text = "Save New";
            this.btnProcSave.UseVisualStyleBackColor = true;
            this.btnProcSave.Click += new System.EventHandler(this.btnProcSave_Click);
            // 
            // lbProcedures
            // 
            this.lbProcedures.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcedures.FormattingEnabled = true;
            this.lbProcedures.ItemHeight = 19;
            this.lbProcedures.Location = new System.Drawing.Point(146, 80);
            this.lbProcedures.Name = "lbProcedures";
            this.lbProcedures.Size = new System.Drawing.Size(128, 536);
            this.lbProcedures.TabIndex = 31;
            this.lbProcedures.TabStop = false;
            this.lbProcedures.SelectedIndexChanged += new System.EventHandler(this.lbProcedures_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 32;
            this.label12.Text = "Procedures";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 648);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbProcedures);
            this.Controls.Add(this.btnProcDelete);
            this.Controls.Add(this.btnProcUpdate);
            this.Controls.Add(this.btnProcSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProcPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.txtProcDesc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProcMinutes);
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnProdUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdDesc);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnProdSave);
            this.Name = "Form1";
            this.Text = "Stock Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.RichTextBox txtProdDesc;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProdUpdate;
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.TextBox txtProcMinutes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProcName;
        private System.Windows.Forms.RichTextBox txtProcDesc;
        private System.Windows.Forms.Button btnProcDelete;
        private System.Windows.Forms.Button btnProcUpdate;
        private System.Windows.Forms.Button btnProcSave;
        private System.Windows.Forms.ListBox lbProcedures;
        private System.Windows.Forms.Label label12;
    }
}

