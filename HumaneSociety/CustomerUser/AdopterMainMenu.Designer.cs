namespace HumaneSociety.CustomerUser
{
    partial class AdopterMainMenu
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
            this.Animals = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.SearchByName = new System.Windows.Forms.Button();
            this.SearchByType = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Animals
            // 
            this.Animals.Location = new System.Drawing.Point(22, 224);
            this.Animals.Name = "Animals";
            this.Animals.ReadOnly = true;
            this.Animals.Size = new System.Drawing.Size(999, 1064);
            this.Animals.TabIndex = 0;
            this.Animals.Text = "";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(116, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(182, 31);
            this.name.TabIndex = 1;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(116, 78);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(182, 31);
            this.Type.TabIndex = 3;
            // 
            // SearchByName
            // 
            this.SearchByName.Location = new System.Drawing.Point(316, 35);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(220, 27);
            this.SearchByName.TabIndex = 4;
            this.SearchByName.Text = "Search By Name";
            this.SearchByName.UseVisualStyleBackColor = true;
            this.SearchByName.Click += new System.EventHandler(this.SearchByName_Click);
            // 
            // SearchByType
            // 
            this.SearchByType.Location = new System.Drawing.Point(316, 78);
            this.SearchByType.Name = "SearchByType";
            this.SearchByType.Size = new System.Drawing.Size(220, 27);
            this.SearchByType.TabIndex = 5;
            this.SearchByType.Text = "Search By Type\r\n";
            this.SearchByType.UseVisualStyleBackColor = true;
            this.SearchByType.Click += new System.EventHandler(this.SearchByType_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(13, 36);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(80, 25);
            this.namelabel.TabIndex = 6;
            this.namelabel.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type: ";
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(316, 121);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(220, 27);
            this.GetAll.TabIndex = 8;
            this.GetAll.Text = "Get All";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // AdopterMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 1315);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.SearchByType);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Animals);
            this.Name = "AdopterMainMenu";
            this.Text = "AdopterMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Animals;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Button SearchByName;
        private System.Windows.Forms.Button SearchByType;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetAll;
    }
}