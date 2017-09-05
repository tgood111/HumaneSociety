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
            this.ImportAnimal = new System.Windows.Forms.Button();
            this.EditAnimal = new System.Windows.Forms.Button();
            this.AdoptAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewAnimal
            // 
            this.NewAnimal.Location = new System.Drawing.Point(28, 31);
            this.NewAnimal.Name = "NewAnimal";
            this.NewAnimal.Size = new System.Drawing.Size(151, 66);
            this.NewAnimal.TabIndex = 0;
            this.NewAnimal.Text = "New Animal";
            this.NewAnimal.UseVisualStyleBackColor = true;
            this.NewAnimal.Click += new System.EventHandler(this.NewAnimal_Click_1);
            // 
            // ImportAnimal
            // 
            this.ImportAnimal.Location = new System.Drawing.Point(185, 31);
            this.ImportAnimal.Name = "ImportAnimal";
            this.ImportAnimal.Size = new System.Drawing.Size(151, 66);
            this.ImportAnimal.TabIndex = 1;
            this.ImportAnimal.Text = "Import Animal";
            this.ImportAnimal.UseVisualStyleBackColor = true;
            this.ImportAnimal.Click += new System.EventHandler(this.ImportAnimal_Click);
            // 
            // EditAnimal
            // 
            this.EditAnimal.Location = new System.Drawing.Point(342, 31);
            this.EditAnimal.Name = "EditAnimal";
            this.EditAnimal.Size = new System.Drawing.Size(151, 66);
            this.EditAnimal.TabIndex = 2;
            this.EditAnimal.Text = "Edit Animal";
            this.EditAnimal.UseVisualStyleBackColor = true;
            this.EditAnimal.Click += new System.EventHandler(this.EditAnimal_Click);
            // 
            // AdoptAnimal
            // 
            this.AdoptAnimal.Location = new System.Drawing.Point(499, 31);
            this.AdoptAnimal.Name = "AdoptAnimal";
            this.AdoptAnimal.Size = new System.Drawing.Size(151, 66);
            this.AdoptAnimal.TabIndex = 3;
            this.AdoptAnimal.Text = "Adopt Animal";
            this.AdoptAnimal.UseVisualStyleBackColor = true;
            this.AdoptAnimal.Click += new System.EventHandler(this.AdoptAnimal_Click);
            // 
            // EmployeeMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(669, 109);
            this.Controls.Add(this.AdoptAnimal);
            this.Controls.Add(this.EditAnimal);
            this.Controls.Add(this.ImportAnimal);
            this.Controls.Add(this.NewAnimal);
            this.Name = "EmployeeMainMenu";
            this.Text = "Humane Society Employee App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewAnimal;
        private System.Windows.Forms.Button ImportAnimal;
        private System.Windows.Forms.Button EditAnimal;
        private System.Windows.Forms.Button AdoptAnimal;
    }
}