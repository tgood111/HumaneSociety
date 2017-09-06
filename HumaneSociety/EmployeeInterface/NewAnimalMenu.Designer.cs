namespace HumaneSociety.EmployeeInterface
{
    partial class EditAnimal
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
            this.AddAnimal = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Shot = new System.Windows.Forms.CheckBox();
            this.FoodIntake = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Room)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAnimal
            // 
            this.AddAnimal.Location = new System.Drawing.Point(89, 436);
            this.AddAnimal.Name = "AddAnimal";
            this.AddAnimal.Size = new System.Drawing.Size(158, 78);
            this.AddAnimal.TabIndex = 0;
            this.AddAnimal.Text = "Add Animal";
            this.AddAnimal.UseVisualStyleBackColor = true;
            this.AddAnimal.Click += new System.EventHandler(this.AddAnimal_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(266, 436);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(152, 78);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(172, 59);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(246, 31);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(172, 114);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(246, 31);
            this.Age.TabIndex = 4;
            this.Age.TextChanged += new System.EventHandler(this.Age_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age:";
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(172, 210);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(246, 31);
            this.Color.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color:";
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(172, 265);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(120, 31);
            this.Room.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Room:";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(172, 315);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(246, 31);
            this.Type.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type:";
            // 
            // Shot
            // 
            this.Shot.AutoSize = true;
            this.Shot.Location = new System.Drawing.Point(172, 362);
            this.Shot.Name = "Shot";
            this.Shot.Size = new System.Drawing.Size(141, 29);
            this.Shot.TabIndex = 12;
            this.Shot.Text = "Has shot?";
            this.Shot.UseVisualStyleBackColor = true;
            // 
            // FoodIntake
            // 
            this.FoodIntake.Location = new System.Drawing.Point(172, 163);
            this.FoodIntake.Name = "FoodIntake";
            this.FoodIntake.Size = new System.Drawing.Size(246, 31);
            this.FoodIntake.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Food Intake:";
            // 
            // EditAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FoodIntake);
            this.Controls.Add(this.Shot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddAnimal);
            this.Name = "EditAnimal";
            this.Text = "EditAnimal";
            this.Load += new System.EventHandler(this.NewAnimalMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAnimal;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Shot;
        private System.Windows.Forms.TextBox FoodIntake;
        private System.Windows.Forms.Label label6;
    }
}