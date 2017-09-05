namespace HumaneSociety.EmployeeInterface
{
    partial class EmployeeMainMenu
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
            this.NewAnimal = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.EditAnimal = new System.Windows.Forms.Button();
            this.Transaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAnimal
            // 
            this.NewAnimal.Location = new System.Drawing.Point(68, 75);
            this.NewAnimal.Name = "NewAnimal";
            this.NewAnimal.Size = new System.Drawing.Size(209, 57);
            this.NewAnimal.TabIndex = 0;
            this.NewAnimal.Text = "Add New Animal";
            this.NewAnimal.UseVisualStyleBackColor = true;
            this.NewAnimal.Click += new System.EventHandler(this.NewAnimal_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(283, 75);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(185, 57);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import Animals";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // EditAnimal
            // 
            this.EditAnimal.Location = new System.Drawing.Point(474, 75);
            this.EditAnimal.Name = "EditAnimal";
            this.EditAnimal.Size = new System.Drawing.Size(150, 57);
            this.EditAnimal.TabIndex = 2;
            this.EditAnimal.Text = "Edit Animal";
            this.EditAnimal.UseVisualStyleBackColor = true;
            // 
            // Transaction
            // 
            this.Transaction.Location = new System.Drawing.Point(631, 75);
            this.Transaction.Name = "Transaction";
            this.Transaction.Size = new System.Drawing.Size(222, 57);
            this.Transaction.TabIndex = 3;
            this.Transaction.Text = "Create Transaction";
            this.Transaction.UseVisualStyleBackColor = true;
            // 
            // EmployeeMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 347);
            this.Controls.Add(this.Transaction);
            this.Controls.Add(this.EditAnimal);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.NewAnimal);
            this.Name = "EmployeeMainMenu";
            this.Text = "EmployeeMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAnimal;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button EditAnimal;
        private System.Windows.Forms.Button Transaction;
    }
}